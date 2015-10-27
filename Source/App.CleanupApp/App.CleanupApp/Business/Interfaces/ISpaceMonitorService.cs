using App.CleanupApp.SpaceMonitorParameters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace App.CleanupApp.Business.Interfaces
{
    public interface ISpaceMonitorService
    {
        void Run(ISpaceMonitor spaceMonitorService);
    }
}
