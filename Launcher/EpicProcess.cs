using System;
using System.IO;
using System.Diagnostics;

namespace SteamLauncher
{
    class EpicProcess
    {      
        public bool IsRunning()
        {           
            Process[] process = Process.GetProcesses();
            foreach (Process o in process)
            {
                if (o.ProcessName == "EpicGamesLauncher" ||
                o.ProcessName == "EpicWebHelper" ||
                o.ProcessName == "Inicializador da Epic Games")
                {
                    return true;
                }
            }
            return false;
        }

        public void StartEpicProcess()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
            
            foreach(string files in Directory.GetFiles(desktopPath) ){
                string file = Path.GetFileNameWithoutExtension(files);

                if(!file.Contains("Epic Games Launcher") ) continue;

                ProcessStartInfo startInfo = new ProcessStartInfo(files);
                startInfo.WindowStyle = ProcessWindowStyle.Minimized;
                startInfo.UseShellExecute = true;
                startInfo.Verb = "open";
                Process.Start(startInfo);

                break;
            }
        }

        public Process StopEpicProcess()
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