using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace App.CleanupApp.Configuration
{
    public class FoldersConfigurationElementCollection : GenericConfigurationElementCollection<FolderConfigurationElement>
    {
        [ConfigurationProperty("LimitSpaceToCleanupInPercentual", IsRequired = true)]
        public decimal LimitSpaceToSendNotificationInPercentual
        {
            get { return Convert.ToDecimal(this["LimitSpaceToCleanupInPercentual"]); }
            set { this["LimitSpaceToCleanupInPercentual"] = value; }
        }
    }
}
