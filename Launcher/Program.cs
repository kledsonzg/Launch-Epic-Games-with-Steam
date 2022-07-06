using System;
using System.Threading;
using System.Diagnostics;

namespace SteamLauncher
{
    class Program
    {
        static void Main()
        {
            EpicProcess epicUtilities = new EpicProcess();
            IniFile settings = new IniFile("settings.ini");
           
            int pauseTime = 0;
            string epicUrl = settings.Read("epicUrl", "Game Settings");
            string exeName = settings.Read("exeName", "Game Settings");
            int.TryParse(settings.Read("pauseTime", "Game Settings"), out pauseTime);
            pauseTime *= 1000;
            bool isRunning = epicUtilities.IsRunning();

            if (String.IsNullOrEmpty(epicUrl) || String.IsNullOrEmpty(exeName) )
            {
                System.Console.WriteLine("ERRO: É necessário o URL e o nome do Executável.");
                return;
            }

            if(isRunning)
                epicUtilities.StopEpicProcess();

            ProcessStartInfo ps = new ProcessStartInfo(epicUrl);
            ps.UseShellExecute = true;
            ps.Verb = "open";

            System.Console.WriteLine($"Abrindo URL do jogo: {epicUrl}");
            Process.Start(ps);
            Process[] gameProcesses = Process.GetProcessesByName(exeName);

            if(pauseTime == 0){
                Console.WriteLine($"Aguardando o jogo iniciar...");

                while(true){
                    Thread.Sleep(1000);
                    gameProcesses = Process.GetProcessesByName(exeName);
                    if(gameProcesses.Length != 1) continue;

                    goto GameStarted;
                }
            }
            else
                Console.WriteLine($"Esperando o inicio do jogo por {pauseTime / 1000} segundo(s)...");
            
            Thread.Sleep(pauseTime);

            gameProcesses = Process.GetProcessesByName(exeName);

            if (gameProcesses.Length != 1)
            {
                System.Console.WriteLine($"Não foi possível identificar o processo: {exeName}");
                return;
            }

            GameStarted:
            System.Console.WriteLine($"Jogo iniciado!");

            while(true){
                Thread.Sleep(1000);
                if (!gameProcesses[0].HasExited) continue;

                string logPrint = "Fechando launcher";

                if(isRunning)
                    logPrint += " e reabrindo a Epic Games.";
                else logPrint += "...";

                Console.WriteLine(logPrint);           

                epicUtilities.StopEpicProcess();
                Thread.Sleep(2000);

                if(isRunning)
                    epicUtilities.StartEpicProcess();

                break;
            }            
        }
    }
}