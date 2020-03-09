using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Monique_Scheurwater_PRM281_Project
{
    //declare delegate 
    public delegate void Del(Changes c);
    public partial class frmMonitorFiles : Form
    {
        Del mydel;
        int ch = 0;
        FileHandler fh = new FileHandler();
        List<string> changes = new List<string>();
        BindingSource bs = new BindingSource();
        public frmMonitorFiles()
        {
            InitializeComponent();
        }
        public string ChooseDirectory()
        {
            string path;
            if (fbdChooseFolder.ShowDialog() == DialogResult.OK)
            {
                fsWatcher.Path = fbdChooseFolder.SelectedPath;
                path = fsWatcher.Path;
                return path;
            }
            else
            {
                return String.Format("No directory chosen");
            }
        }
        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            ChooseDirectory();
        }
        public void Watcher()
        {
            // watches for all the changes in the LastWrite, LastAccess and renaming
            fsWatcher.NotifyFilter = NotifyFilters.LastAccess 
                                    |NotifyFilters.LastWrite
                                    |NotifyFilters.FileName 
                                    |NotifyFilters.DirectoryName;
            //My events
            fsWatcher.Changed += (OnChanged);
            fsWatcher.Created += (OnChanged);
            fsWatcher.Deleted += (OnChanged);
            fsWatcher.Renamed += (OnRenamed);
            //Begin monitoring
            fsWatcher.EnableRaisingEvents = true;

        }
        //source is the is "source" of the event - in this case it is the timer
        //well, the source should be whatever object invoked the event,
        //which in this case seems to some Timer,
        private void OnChanged(object source, FileSystemEventArgs dave)
        {//eventhandler
            WatcherChangeTypes wct = dave.ChangeType;
            string fullpath = dave.FullPath;
            string m = fullpath + " " + wct.ToString();
            MessageBox.Show(fullpath + " was " + wct.ToString(), "File was " + wct.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            changes.Add(m);
            lbxShowChanges.DataSource = null;
            lbxShowChanges.DataSource = changes;
            lblUpdateChange.Visible = true;
            lblUpdateChange.Text = m;
            ch++;
            Changes c = new Changes();
            mydel = new Del(WriteChange);
            c.Full = fullpath;
            c.Changetype = wct.ToString();
            mydel(c);
            
        }
        //eventhandler
        private void OnRenamed(object source, RenamedEventArgs rick)
        {
            WatcherChangeTypes wct = rick.ChangeType;
            string fullpath = rick.FullPath;
            string oldpath = rick.OldFullPath;
            string m =oldpath + " " + fullpath + " " + wct.ToString();
            MessageBox.Show(oldpath + " was " + wct.ToString() + " to " + fullpath ,"File was " + wct.ToString(),MessageBoxButtons.OK, MessageBoxIcon.Information);
            changes.Add(m);
            lbxShowChanges.DataSource = null;
            lbxShowChanges.DataSource = changes;
            lblUpdateChange.Visible = true;
            lblUpdateChange.Text = m;
            ch++;
            Changes c = new Changes();
            mydel = new Del(WriteChange);
            c.Full = fullpath;
            c.Changetype = wct.ToString();
            mydel(c);
        }
        
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            btnStop.ForeColor = Color.Black;
            btnMonitor.ForeColor = Color.Green;
            Watcher();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnMonitor.ForeColor = Color.Black;
            btnStop.ForeColor = Color.Red;
            fsWatcher.EnableRaisingEvents = false;
            lblHowMany.Visible = true;
            lblHowMany.Text = "You made " + ch + " changes";
        } 

        private void frmMonitorFiles_Load(object sender, EventArgs e)
        {

        }

        private void btnALLchanges_Click(object sender, EventArgs e)
        {
            dgvShow.Visible = true;
            lbxShowChanges.Visible = false;
            List<Changes> c = new List<Changes>();
            fh.Read(c);
            foreach (var item in c)
            {
                bs.Add(item);
            }
            dgvShow.DataSource = bs;

        }
        public void WriteChange(Changes c)
        {
            fh.WriterRename(c);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit the application?","Exit application",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Thread.Sleep(1000);
                Application.Exit();
            }
            else if (dr == DialogResult.Cancel)
            {
                
            }
        }
    }
}
