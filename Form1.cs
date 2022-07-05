using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Launch_Epic_Games_with_Steam
{
    public partial class Form1 : Form
    {
        inkManager myShortcut;
        string epicShortcut = null;
        string lastTimeString = "";
        Color default_debug_color;
        
        public Form1()
        {
            InitializeComponent();
            Iniciar();

            pictureBox1.Parent = bckPanel;
            pictureBox2.Parent = bckPanel;
            pictureBox3.Parent = bckPanel;
            pictureBox4.Parent = bckPanel;
            pictureBox5.Parent = bckPanel;

            TransparencyKey = Color.Empty;
        }
        
        void Iniciar()
        {
            string file = string.Format(@"{0}\", Path.GetDirectoryName(Application.ExecutablePath));
            debugBox.Text = file;
            default_debug_color = debugBox.ForeColor;
            openInkFile.DereferenceLinks = false;

            if (File.Exists(file))
            {
                IniFile settings = new IniFile("settings.ini");
                epicUrl.Text = settings.Read("epicUrl", "Game Settings");
                exeName.Text = settings.Read("exeName", "Game Settings");
                timeBox.Text = settings.Read("pauseTime", "Game Settings");
                lastTimeString = timeBox.Text;
            }
            timeBox.TextChanged += delegate { ValidateTextBoxAsNumber(timeBox); };
        }

        private void ValidateTextBoxAsNumber(TextBox textBox)
        {
            int number = 0;
            bool isNumber = int.TryParse(textBox.Text, out number);
            if (isNumber) return;

            timeBox.Text = lastTimeString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(timeBox.Text))
                timeBox.Text = "0";
            if (!string.IsNullOrEmpty(exeName.Text) && !string.IsNullOrEmpty(epicUrl.Text) )
                CreateSteamShortcut();
            else
            {
                debugBox.ForeColor = Color.Red;
                debugBox.Text = "O campo 'url' e o campo 'executável' não podem ficar vazios!";
            }             
        }

        void CreateSteamShortcut()
        {
            debugBox.ForeColor = default_debug_color;

            if (!Directory.Exists($@"{Path.GetDirectoryName(Application.ExecutablePath)}\{exeName.Text}\")) {
                Directory.CreateDirectory($@"{Path.GetDirectoryName(Application.ExecutablePath)}\{exeName.Text}\");
            }

            string usingPath = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\{exeName.Text}";

            debugBox.Text = "Criando arquivo...";
            System.Threading.Thread.Sleep(2000);
            File.Create($@"{usingPath}\settings.ini").Dispose();
            
            IniFile settings = new IniFile($"{usingPath}\\settings.ini");

            settings.Write("epicUrl", epicUrl.Text, "Game Settings");
            settings.Write("exeName", exeName.Text, "Game Settings");
            settings.Write("pauseTime", timeBox.Text, "Game Settings");

            File.Copy($@"{Path.GetDirectoryName(Application.ExecutablePath)}\Launcher\Launcher.exe", $"{usingPath}\\Launcher.exe", true);
            File.Copy($@"{Path.GetDirectoryName(Application.ExecutablePath)}\Launcher\Launcher.dll", $"{usingPath}\\Launcher.dll", true);
            File.Copy($@"{Path.GetDirectoryName(Application.ExecutablePath)}\Launcher\Launcher.pdb", $"{usingPath}\\Launcher.pdb", true);
            File.Copy($@"{Path.GetDirectoryName(Application.ExecutablePath)}\Launcher\Launcher.runtimeconfig.json", $"{usingPath}\\Launcher.runtimeconfig.dev.json", true);
            File.Copy($@"{Path.GetDirectoryName(Application.ExecutablePath)}\Launcher\Launcher.deps.json", $"{usingPath}\\Launcher.deps.json", true);

            myShortcut.CreateShortcut($"{usingPath}\\Launcher.exe", epicShortcut);

            debugBox.Text = $"Sucesso! Foi gerado uma pasta com configurações personalizadas! ({exeName.Text})";
        }

        private void openExeFile_FileOk(object sender, CancelEventArgs e)
        {
            debugBox.ForeColor = default_debug_color;

            exeName.Text = string.Format("{0}", Path.GetFileNameWithoutExtension(openExeFile.FileName));

            epicShortcut = openExeFile.FileName;
            debugBox.Text = epicShortcut;
        }

        private void searchExe_Click(object sender, EventArgs e)
        {
            openExeFile.ShowDialog();
        }

        private void searchUrl_Click(object sender, EventArgs e)
        {
            openInkFile.ShowDialog();
        }

        void openInkFile_FileOk(object sender, CancelEventArgs e)
        {
            debugBox.ForeColor = default_debug_color;
            
            inkManager INK = new inkManager();
            string path = openInkFile.FileName;
            debugBox.Text = path;

           myShortcut = INK.ManageThisShortcut(path, this);
        }

        private void debugBox_Enter(object sender, EventArgs e)
        {
            debugBox.Enabled = false;
            debugBox.Enabled = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa foi criado por KledsonZG!\n\n\nAgradecimentos:\n\nseanzwrites.com\n\n(Fez um post mostrando como é possível abrir um\njogo da epic games sem mostrar erros\ncom a steam.)", "Sobre", 0, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/ZombieGamerK");
        }
        private void exeName_Enter(object sender, EventArgs e)
        {
            exeName.Enabled = false;
            exeName.Enabled = true;
        }
    }
}