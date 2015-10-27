using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.CleanupApp.Business.Interfaces
{
    public interface IDriverServiceFactory
    {
        IDriverService Create();
    }
}
