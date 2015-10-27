using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.CleanupApp.SpaceMonitorParameters.Interfaces
{
    public interface IFolders : IEnumerable<IFolder>
    {
        decimal LimitSpaceToCleanupInPercentual { get; }
        void Add(IFolder folder);
    }
}
