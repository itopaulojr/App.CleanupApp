using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.CleanupApp.Configuration
{
    public class FolderConfigurationElement : ConfigurationElement
    {
        public FolderConfigurationElement() { }

        [ConfigurationProperty("Path", IsRequired = true)]
        public string Path
        {
            get { return (string)this["Path"]; }
            set { this["Path"] = value; }
        }
    }
}
