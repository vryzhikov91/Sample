using System;
using System.Collections;
using System.IO;

using System.ServiceProcess;

namespace MyTestCoreWindowsService{
    public class LoggingService : ServiceBase{
        private const string _logFileLocation = @"C:\temp\servicelog.txt";

        private void Log(string logMessage){
            Directory.CreateDirectory(Path.GetDirectoryName(_logFileLocation));
            File.AppendAllText(_logFileLocation, DateTime.UtcNow.ToString() + " : " + logMessage + Environment.NewLine);
        }

        protected override void OnStart(string[] args){
            Log("Starting");
            base.OnStart(args);
            PerfCounter.PerfCounter.Main();
                

        }

        protected override void OnStop(){
            Log("Stopping");
            base.OnStop();
        }

        protected override void OnPause(){
            Log("Pausing");
            base.OnPause();
        }
    }
}
