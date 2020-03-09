namespace Monique_Scheurwater_PRM281_Project
{
    partial class frmMonitorFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblUpdateChange = new System.Windows.Forms.Label();
            this.btnChooseDirectory = new System.Windows.Forms.Button();
            this.gbxChanges = new System.Windows.Forms.GroupBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.lbxShowChanges = new System.Windows.Forms.ListBox();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.gbxMonitor = new System.Windows.Forms.GroupBox();
            this.lblHowMany = new System.Windows.Forms.Label();
            this.fbdChooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.fsWatcher = new System.IO.FileSystemWatcher();
            this.btnALLchanges = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxChanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.gbxMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(262, 20);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(293, 37);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "MONITOR FILES :)";
            // 
            // lblUpdateChange
            // 
            this.lblUpdateChange.AutoSize = true;
            this.lblUpdateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateChange.Location = new System.Drawing.Point(318, 313);
            this.lblUpdateChange.Name = "lblUpdateChange";
            this.lblUpdateChange.Size = new System.Drawing.Size(162, 18);
            this.lblUpdateChange.TabIndex = 1;
            this.lblUpdateChange.Text = "Changes when updated";
            this.lblUpdateChange.Visible = false;
            // 
            // btnChooseDirectory
            // 
            this.btnChooseDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseDirectory.Location = new System.Drawing.Point(30, 88);
            this.btnChooseDirectory.Name = "btnChooseDirectory";
            this.btnChooseDirectory.Size = new System.Drawing.Size(224, 49);
            this.btnChooseDirectory.TabIndex = 2;
            this.btnChooseDirectory.Text = "Choose directory";
            this.btnChooseDirectory.UseVisualStyleBackColor = true;
            this.btnChooseDirectory.Click += new System.EventHandler(this.btnChooseDirectory_Click);
            // 
            // gbxChanges
            // 
            this.gbxChanges.Controls.Add(this.dgvShow);
            this.gbxChanges.Controls.Add(this.lbxShowChanges);
            this.gbxChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChanges.Location = new System.Drawing.Point(294, 88);
            this.gbxChanges.Name = "gbxChanges";
            this.gbxChanges.Size = new System.Drawing.Size(540, 222);
            this.gbxChanges.TabIndex = 3;
            this.gbxChanges.TabStop = false;
            this.gbxChanges.Text = "Changes";
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(27, 19);
            this.dgvShow.Name = "dgvShow";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.Size = new System.Drawing.Size(496, 184);
            this.dgvShow.TabIndex = 1;
            this.dgvShow.Visible = false;
            // 
            // lbxShowChanges
            // 
            this.lbxShowChanges.FormattingEnabled = true;
            this.lbxShowChanges.ItemHeight = 18;
            this.lbxShowChanges.Location = new System.Drawing.Point(27, 19);
            this.lbxShowChanges.Name = "lbxShowChanges";
            this.lbxShowChanges.ScrollAlwaysVisible = true;
            this.lbxShowChanges.Size = new System.Drawing.Size(496, 184);
            this.lbxShowChanges.TabIndex = 0;
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(36, 44);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(150, 38);
            this.btnMonitor.TabIndex = 4;
            this.btnMonitor.Text = "Start monitoring";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(36, 93);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 35);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop Monitoring";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // gbxMonitor
            // 
            this.gbxMonitor.Controls.Add(this.btnMonitor);
            this.gbxMonitor.Controls.Add(this.btnStop);
            this.gbxMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMonitor.Location = new System.Drawing.Point(34, 148);
            this.gbxMonitor.Name = "gbxMonitor";
            this.gbxMonitor.Size = new System.Drawing.Size(220, 162);
            this.gbxMonitor.TabIndex = 4;
            this.gbxMonitor.TabStop = false;
            this.gbxMonitor.Text = "Monitor";
            // 
            // lblHowMany
            // 
            this.lblHowMany.AutoSize = true;
            this.lblHowMany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowMany.Location = new System.Drawing.Point(31, 313);
            this.lblHowMany.Name = "lblHowMany";
            this.lblHowMany.Size = new System.Drawing.Size(216, 18);
            this.lblHowMany.TabIndex = 5;
            this.lblHowMany.Text = "How many changes were made";
            this.lblHowMany.Visible = false;
            // 
            // fsWatcher
            // 
            this.fsWatcher.EnableRaisingEvents = true;
            this.fsWatcher.IncludeSubdirectories = true;
            this.fsWatcher.SynchronizingObject = this;
            // 
            // btnALLchanges
            // 
            this.btnALLchanges.Location = new System.Drawing.Point(667, 47);
            this.btnALLchanges.Name = "btnALLchanges";
            this.btnALLchanges.Size = new System.Drawing.Size(150, 35);
            this.btnALLchanges.TabIndex = 6;
            this.btnALLchanges.Text = "Display ALL changes";
            this.btnALLchanges.UseVisualStyleBackColor = true;
            this.btnALLchanges.Click += new System.EventHandler(this.btnALLchanges_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(760, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMonitorFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(859, 362);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnALLchanges);
            this.Controls.Add(this.lblHowMany);
            this.Controls.Add(this.gbxMonitor);
            this.Controls.Add(this.gbxChanges);
            this.Controls.Add(this.btnChooseDirectory);
            this.Controls.Add(this.lblUpdateChange);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMonitorFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor files :)";
            this.Load += new System.EventHandler(this.frmMonitorFiles_Load);
            this.gbxChanges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.gbxMonitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblUpdateChange;
        private System.Windows.Forms.Button btnChooseDirectory;
        private System.Windows.Forms.GroupBox gbxChanges;
        private System.Windows.Forms.ListBox lbxShowChanges;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox gbxMonitor;
        private System.Windows.Forms.Label lblHowMany;
        private System.Windows.Forms.FolderBrowserDialog fbdChooseFolder;
        private System.IO.FileSystemWatcher fsWatcher;
        private System.Windows.Forms.Button btnALLchanges;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnExit;
    }
}

