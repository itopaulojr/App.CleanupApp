using App.CleanupApp.SpaceMonitorParameters;
using App.CleanupApp.SpaceMonitorParameters.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App.CleanupApp.Configuration
{
    public class DriverMonitorHelper
    {
        public static ISpaceMonitor DriverMonitor
        {
            get
            {

                var spaceMonitorConfigurationSection = ConfigurationManager.GetSection("SpaceMonitor") as SpaceMonitorConfigurationSection;

                SpaceMonitor spaceMonitor = new SpaceMonitor();
                List<Driver> auxDrivers = new List<Driver>();
                foreach (var driverConfigSection in spaceMonitorConfigurationSection.Drivers)
                {
                    Driver driver = new Driver();
                    driver.Letter = driverConfigSection.Letter;
                    driver.LimitSpaceToSendNotificationInPercentual = driverConfigSection.LimitSpaceToSendNotificationInPercentual;

                    Folders auxFolders = new Folders();
                    auxFolders.LimitSpaceToCleanupInPercentual = driverConfigSection.Folders.LimitSpaceToSendNotificationInPercentual;
                    foreach (var folderConfigSection in driverConfigSection.Folders)
                    {
                        Folder folder = new Folder();
                        folder.Path = folderConfigSection.Path;
                        auxFolders.Add(folder);
                    }
                    driver.Folders = auxFolders;
                    auxDrivers.Add(driver);
                }
                spaceMonitor.Drivers = auxDrivers;

                return spaceMonitor;

                
            }
        }
    }
}
