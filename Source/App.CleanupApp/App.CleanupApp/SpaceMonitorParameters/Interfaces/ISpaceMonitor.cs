using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.CleanupApp.SpaceMonitorParameters.Interfaces
{
    public interface ISpaceMonitor
    {
        IEnumerable<IDriver> Drivers { get; }
    }
}
