using App.CleanupApp.SpaceMonitorParameters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace App.CleanupApp.SpaceMonitorParameters
{
    public class Folders : IFolders
    {
        List<IFolder> folders = new List<IFolder>();

        public IFolder this[int index]
        {
            get { return folders[index]; }
            set { folders.Insert(index, value); }
        }

        public IEnumerator<IFolder> GetEnumerator()
        {
            return folders.GetEnumerator();
        }

       

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(IFolder folder)
        {
            folders.Add(folder);
        }
    }
}
