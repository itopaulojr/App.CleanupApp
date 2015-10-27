using App.CleanupApp.SpaceMonitorParameters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.CleanupApp.Business.Interfaces
{
    public interface IDriverService
    {
        void Run(IDriver driver);

        bool NotificationSent();
        bool FolderCompressed();
        bool CompressedFiledCleanedUp();
    }
}
