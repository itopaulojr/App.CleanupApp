using App.CleanupApp.SpaceMonitorParameters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.CleanupApp.SpaceMonitorParameters
{
    public class Driver : IDriver
    {
        public string Letter { get; set; }

        public decimal LimitSpaceToSendNotificationInPercentual { get; set; }

        public IFolders Folders { get; set; }
    }
}
