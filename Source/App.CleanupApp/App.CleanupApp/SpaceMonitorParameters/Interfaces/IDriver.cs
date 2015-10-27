using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.CleanupApp.SpaceMonitorParameters.Interfaces
{
    public interface IDriver
    {
        string Letter { get; }
        decimal LimitSpaceToSendNotificationInPercentual { get; }
        IFolders Folders { get; }
    }
}
