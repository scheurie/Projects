using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Monique_Scheurwater_PRM281_Project
{
    class filewatcher
    {
        private string path;
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public filewatcher(string path)
        {
            this.path = path;
        }
        public filewatcher()
        {

        }
        List<string> c = new List<string>();
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        
        public void W()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length != 2)
            {
                Thread.Sleep(2000);
                MessageBox.Show("No command chosen bye", " ", MessageBoxButtons.OK);
                //Environment.Exit(0);
            }

            using (FileSystemWatcher fsw = new FileSystemWatcher())
            {
                fsw.Path = args[1];
                //fsw.Path = path;
                fsw.NotifyFilter = NotifyFilters.LastAccess
                                  |NotifyFilters.LastWrite
                                  |NotifyFilters.FileName
                                  |NotifyFilters.DirectoryName;

                fsw.Changed += new FileSystemEventHandler(OnChanged);
                fsw.Renamed += new RenamedEventHandler(OnRenamed);
                fsw.Created += new FileSystemEventHandler(OnChanged);
                fsw.Deleted += new FileSystemEventHandler(OnChanged);
                fsw.Filter = "*";
                fsw.IncludeSubdirectories = true;
                fsw.EnableRaisingEvents = true;
            }
        }

        public void OnChanged(object source, FileSystemEventArgs dave)
        {
            WatcherChangeTypes wct = dave.ChangeType;
            string fullpath = dave.FullPath;
            string m = fullpath + " " + wct.ToString();
            c.Add(m);
        }

        public void OnRenamed(object source, RenamedEventArgs rick)
        {
            WatcherChangeTypes wct = rick.ChangeType;
            string fullpath = rick.FullPath;
            string oldpath = rick.OldFullPath;
            string m = oldpath + " " + fullpath + " " + wct.ToString();
            c.Add(m);
        }
    }
    
}
