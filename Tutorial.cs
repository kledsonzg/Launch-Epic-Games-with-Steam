using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Launch_Epic_Games_with_Steam
{
    internal class Tutorial
    {
        Form1 form1 = null;
        public ImageViewer viewer = null;
        Thread tutorialThread = null;
        string directory;
        string file;
        int Step = 0;
        bool blinkLoop;
        public Tutorial(Form1 instance)
        {
            form1 = instance;
            directory = Path.GetDirectoryName(Application.ExecutablePath);
            file = directory + @"\tutorial_ok";
        }

        public void Check()
        {         
            if (File.Exists(file))
                return;


            DialogResult dialog = MessageBox.Show($"Olá! Seja bem-vindo!{Environment.NewLine}{Environment.NewLine}Parece que você nunca deu uma olhada no nosso tutorial.{Environment.NewLine}Gostaria de ver nosso tutorial?{Environment.NewLine}{Environment.NewLine}Sim: Mostrar o tutorial.{Environment.NewLine}Não: Não preciso.{Environment.NewLine}Cancelar: Talvez depois.", "Boas vindas!", MessageBoxButtons.YesNoCancel);
            switch (dialog)
            {
                case DialogResult.Yes:
                    {
                        OpenTutorial();
                        File.Create(file).Dispose();
                        break;
                    }
                case DialogResult.No:
                    {
                        File.Create(file).Dispose();
                        break;
                    }
                case DialogResult.Cancel: break;

            }

        }

        public int GetStep() => Step;

        public void OpenTutorial()
        {
            if (Step != 0)
                return;

            NextStep();
        }

        void WaitForDialogResponse(DialogResult dialog)
        {
            while (dialog != DialogResult.OK)
            {
                Debug.WriteLine("checking...");
                continue;
            }
            blinkLoop = false;
        }

        public void NextStep()
        {         
            DialogResult dialog = DialogResult.None;
            bool okClick = false;
            Step++;

            if (Step > 13)
                Step = 0;

            form1.Activate();
            if (Step > 0 && Step < 9 || Step == 13)
                form1.Activate();
            else if (Step > 0)
                viewer.Activate();

            switch (Step)
            {
                case 1:
                    {
                        if (!File.Exists(file))
                            File.Create(file).Dispose();
                        
                        dialog = MessageBox.Show($@"Obrigado por usar este programa!{Environment.NewLine}{Environment.NewLine}Iremos lhe mostrar agora como utilizar este software.{Environment.NewLine}Pressione ""Ok"" para prosseguir.", "Boas Vindas!", MessageBoxButtons.OK);
                        break;
                    }
                case 2:
                    {
                        tutorialThread = new Thread(() => ShowDialog($"Nesta caixa de texto, você deverá colocar o atalho do jogo desejado.{Environment.NewLine}{Environment.NewLine}Caso não tenha o atalho do jogo na sua área de trabalho, você poderá criar este atalho na Epic Games.", "Atalho do Jogo - Passo 1"));
                        tutorialThread.Start();

                        blinkLoop = true;
                        BlinkBox(1);
                        break;
                    }
                case 3:
                    {
                        tutorialThread = new Thread(() => ShowDialog($"Para selecionar o atalho do jogo desejado de forma fácil, pressione o botão indicado para abrir a janela do Explorador de Arquivos. {Environment.NewLine}Selecione o atalho do jogo na sua área de trabalho.", "Atalho do Jogo - Passo 1"));
                        tutorialThread.Start();

                        blinkLoop = true;
                        BlinkPicture(form1.searchUrl);
                        break;
                    }
                case 4:
                    {
                        tutorialThread = new Thread(() => ShowDialog($"Nesta caixa de texto, você deverá colocar o executável principal do jogo desejado.", "Executável do Jogo - Passo 2"));
                        tutorialThread.Start();

                        blinkLoop = true;
                        BlinkBox(2);
                        break;
                    }
                case 5:
                    {
                        tutorialThread = new Thread(() => ShowDialog($"Para selecionar o executável do jogo desejado de forma fácil, pressione o botão indicado para abrir a janela do Explorador de Arquivos. {Environment.NewLine}Selecione o executável do jogo na pasta de onde o jogo foi instalado.", "Executável do Jogo - Passo 2"));
                        tutorialThread.Start();

                        blinkLoop = true;
                        BlinkPicture(form1.searchExe);
                        break;
                    }
                case 6:
                    {
                        tutorialThread = new Thread(() => ShowDialog($"Nesta caixa de texto, você pode escolher o tempo em que o Launcher irá ficar pausado antes de iniciar a busca do processo do jogo.{Environment.NewLine}{Environment.NewLine}Colocar um tempo de espera fará com que seu computador utilize menos processamento na busca de processos.{Environment.NewLine}Do contrário, o launcher irá ficar procurando pelo processo do jogo infinitamente a cada 1 segundo.", "Tempo de espera - Passo 3 (Opcional)"));
                        tutorialThread.Start();

                        blinkLoop = true;
                        BlinkBox(3);
                        break;
                    }
                case 7:
                    {
                        tutorialThread = new Thread(() => ShowDialog($"Pressione este botão para salvar um novo atalho do jogo com as configurações para fazer o launcher funcionar corretamente", "Salvando o Atalho - Passo 4"));
                        tutorialThread.Start();

                        blinkLoop = true;
                        BlinkButton(form1.button1);
                        break;
                    }
                case 8:
                    {
                        viewer = new ImageViewer();
                        viewer.Show();
                        viewer.SetTutorialImage(Step - 7);


                        dialog = MessageBox.Show($@"Ao salvar o atalho, você deverá ir na sua biblioteca da Steam.{Environment.NewLine}Na sua biblioteca steam, clique em:{Environment.NewLine} 1: ""Adicionar jogo"" {Environment.NewLine} 2: ""Adicionar um jogo não steam"".", "Configurando o jogo na Steam - Passos finais", MessageBoxButtons.OK);
                        break;
                    }
                case 9:
                    {
                        viewer.SetTutorialImage(Step - 7);

                        dialog = MessageBox.Show($@"1: Selecione o atalho criado com este softwate na lista da Steam.{Environment.NewLine}***: Pode ser que o atalho não apareça nesta lista. Você pode clicar em ´""Procurar"" e selecionar o atalho manualmente com a janela que irá se abrir.{Environment.NewLine}2: Selecione ""Adicionar Selecionados"" para prosseguir.", "Configurando o jogo na Steam - Passos finais", MessageBoxButtons.OK);
                        break;
                    }
                case 10:
                    {
                        viewer.SetTutorialImage(Step - 7);

                        dialog = MessageBox.Show($@"Com o atalho adicionado na sua biblioteca Steam:{Environment.NewLine}{Environment.NewLine}Clique com o botão direito do mouse em cima do jogo adicionado e selecione ""Propriedades"". ", "Configurando o jogo na Steam - Passos finais", MessageBoxButtons.OK);
                        break;
                    }
                case 11:
                    {
                        viewer.SetTutorialImage(Step - 7);

                        dialog = MessageBox.Show($@"Na janela de 'Propriedades' você pode: {Environment.NewLine}{Environment.NewLine}Trocar o nome do atalho{Environment.NewLine}Trocar o ícone do atalho selecionando qualquer executável que possua o ícone desejado.", "Configurando o jogo na Steam - Passos finais", MessageBoxButtons.OK);
                        break;
                    }
                case 12:
                    {
                        viewer.SetTutorialImage(Step - 7);

                        dialog = MessageBox.Show($@"E pronto!{Environment.NewLine}{Environment.NewLine}Você pode iniciar o jogo na sua biblioteca steam e também adicionar na sua Área de Trabalho este novo atalho da Steam.{Environment.NewLine}Adicionando o novo atalho da Steam na área de trabalho, você poderá abrir diretamente da sua área de trabalho o jogo com a Steam!", "Configurando o jogo na Steam - Passos finais", MessageBoxButtons.OK);
                        break;
                    }
                case 13:
                    {
                        viewer.Dispose();

                        tutorialThread = new Thread(() => ShowDialog($"Pressione este botão para visualizar este tutorial novamente!{Environment.NewLine}{Environment.NewLine}Bom jogo!", "Fim do tutorial"));
                        tutorialThread.Start();

                        blinkLoop = true;
                        BlinkPicture(form1.tutorialButton);

                        
                        break;

                    }
            }

            if (dialog == DialogResult.OK)
            {
                okClick = true;
            }

            if (okClick)
                NextStep();
        }

        void BlinkBox(int option)
        {
            while (blinkLoop)
            {
                form1.ChangeTextBoxColor(option);

                Thread.Sleep(1000);
            }
            form1.ResetAllTextBoxColors();
            NextStep();
        }

        void BlinkPicture(PictureBox picture)
        {
            Color color = picture.BackColor;
            while (blinkLoop)
            {
                if (picture.BackColor == color)
                    picture.BackColor = Color.Green;
                else picture.BackColor = color;

                picture.Update();
                Thread.Sleep(1000);
            }
            picture.BackColor = color;
            picture.Update();
            NextStep();
        }

        void BlinkButton(Button button)
        {
            while(blinkLoop)
            {
                if (button.FlatAppearance.BorderSize == 0)
                    button.FlatAppearance.BorderSize = 5;
                else button.FlatAppearance.BorderSize = 0;
                button.Update();
                Thread.Sleep(1000);
            }
            button.FlatAppearance.BorderSize = 0;
            button.Update();
            NextStep();
        }

        void ShowDialog(string message, string caption)
        {
            DialogResult dialog = DialogResult.None;

            dialog = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            if(dialog == DialogResult.OK)
            {
                blinkLoop = false;
            }
        }
    }
}