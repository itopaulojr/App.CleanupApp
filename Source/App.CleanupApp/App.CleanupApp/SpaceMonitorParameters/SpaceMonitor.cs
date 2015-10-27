using App.CleanupApp.SpaceMonitorParameters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.CleanupApp.SpaceMonitorParameters
{
    public class SpaceMonitor : ISpaceMonitor
    {
        public IEnumerable<IDriver> Drivers { get; set; }
    }
}
