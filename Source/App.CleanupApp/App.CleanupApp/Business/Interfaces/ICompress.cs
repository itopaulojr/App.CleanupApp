using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.CleanupApp.Business.Interfaces
{
    public interface ICompress
    {
        bool Compress(string folderPathToCompress, string targetPathToSaveCompressedFile);
    }
}
