using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.CleanupApp.SpaceMonitorParameters.Interfaces
{
    public interface ISpaceMonitor
    {
        IEnumerable<IDriver> Drivers { get; }
    }
}
