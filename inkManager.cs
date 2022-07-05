using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace Launch_Epic_Games_with_Steam
{
    class inkManager
    {
        string shortName = "Run Game!";
        
        public inkManager ManageThisShortcut(string str, Form1 referencia)
        {
            string usingPath = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\temp\";

            if (!Directory.Exists(usingPath))
                Directory.CreateDirectory(usingPath);

            System.IO.File.Copy(str, usingPath + Path.GetFileNameWithoutExtension(str) + ".ini", true);
            var reader = new IniFile($"{usingPath}{Path.GetFileNameWithoutExtension(str)}.ini");

            referencia.epicUrl.Text = reader.Read("URL", "InternetShortcut");

            if (Directory.Exists(usingPath))
                Directory.Delete(usingPath, true);

            shortName = Path.GetFileNameWithoutExtension(str);

            return this;
        }
        public void CreateShortcut(string target, string epicShortcut)
        {
            //Creating Desktop Shortcut
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var shell = new WshShell();
            var shortcut = (IWshShortcut)shell.CreateShortcut($"{desktop}\\Run {shortName}.lnk");

            if (!string.IsNullOrEmpty(epicShortcut)) shortcut.IconLocation = epicShortcut;
            shortcut.TargetPath = target;
            shortcut.Description = "Criado por KledsonZG\nLaunch Epic Games with Steam";
            shortcut.Save();
        }
    }
}
