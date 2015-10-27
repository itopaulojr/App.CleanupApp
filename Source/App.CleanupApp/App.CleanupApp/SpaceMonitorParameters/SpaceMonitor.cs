using App.CleanupApp.SpaceMonitorParameters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.CleanupApp.SpaceMonitorParameters
{
    public class SpaceMonitor : ISpaceMonitor
    {
        public IEnumerable<IDriver> Drivers { get; set; }
    }
}
