using System;
using System.Threading;
using System.Diagnostics;

namespace SteamLauncher
{
    class Program
    {
        static void Main()
        {
            Program epic = new Program();
            epic.StopEpicProcess();

            IniFile settings = new IniFile("settings.ini");

            int pauseTime = 0;
            string epicUrl = settings.Read("epicUrl", "Game Settings");
            string exeName = settings.Read("exeName", "Game Settings");
            int.TryParse(settings.Read("pauseTime", "Game Settings"), out pauseTime);
            pauseTime *= 1000;

            if (String.IsNullOrEmpty(epicUrl) || String.IsNullOrEmpty(exeName) )
            {
                System.Console.WriteLine("ERRO: É necessário o URL e o nome do Executável.");
                return;
            }

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
                Console.WriteLine("Fechando launcher...");            

                epic.StopEpicProcess();
                Thread.Sleep(3000);     
                break;
            }            
        }

        Process StopEpicProcess()
        {
            Process mainProcess = null;
            
            Process[] process = Process.GetProcesses();
            foreach (Process o in process)
            {
                if (o.ProcessName == "EpicGamesLauncher" ||
                o.ProcessName == "EpicWebHelper" ||
                o.ProcessName == "Inicializador da Epic Games")
                {
                    mainProcess = o;
                    o.Kill();
                }
            }
            return mainProcess;
        }
    }
}