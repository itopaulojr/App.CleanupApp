using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.CleanupApp.Configuration
{
    public class DriverConfigurationElement : ConfigurationElement
    {
        public DriverConfigurationElement() { }

        [ConfigurationProperty("Letter", IsRequired = true)]
        public string Letter
        {
            get { return (string)this["Letter"]; }
            set { this["Letter"] = value; }
        }

        [ConfigurationProperty("LimitSpaceToSendNotificationInPercentual", IsRequired = true)]
        public decimal LimitSpaceToSendNotificationInPercentual
        {
            get { return Convert.ToDecimal(this["LimitSpaceToSendNotificationInPercentual"]); }
            set { this["LimitSpaceToSendNotificationInPercentual"] = value; }
        }

        [ConfigurationProperty("Folders", IsRequired = true)]
        [ConfigurationCollection(typeof(FolderConfigurationElement), AddItemName = "Folder", ClearItemsName = "clear", RemoveItemName = "remove")]
        public FoldersConfigurationElementCollection Folders
        {
            get { return (FoldersConfigurationElementCollection)this["Folders"]; }
        }

    }
}
