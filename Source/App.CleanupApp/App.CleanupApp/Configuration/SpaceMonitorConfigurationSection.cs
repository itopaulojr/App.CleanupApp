using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.CleanupApp.Configuration
{
    public class SpaceMonitorConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("Drivers", IsRequired = true)]
        [ConfigurationCollection(typeof(DriverConfigurationElement), AddItemName = "Driver", ClearItemsName = "clear", RemoveItemName = "remove")]
        public GenericConfigurationElementCollection<DriverConfigurationElement> Drivers
        {
            get { return (GenericConfigurationElementCollection<DriverConfigurationElement>)this["Drivers"]; }
        }
    }
}
