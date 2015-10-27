using App.CleanupApp.Configuration;
using App.CleanupApp.SpaceMonitorParameters.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace App.CleanupApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ISpaceMonitor parameter = DriverMonitorHelper.DriverMonitor;
            

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new Service1() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
