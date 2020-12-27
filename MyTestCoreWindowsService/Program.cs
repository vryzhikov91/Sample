using System;
using System.ServiceProcess;

namespace MyTestCoreWindowsService
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ServiceBase.Run(new LoggingService());

        }
    }
}
