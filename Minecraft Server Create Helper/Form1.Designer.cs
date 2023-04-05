namespace msch
{
    partial class mainform
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.serversel = new System.Windows.Forms.ComboBox();
            this.labelserverfile = new System.Windows.Forms.Label();
            this.versel = new System.Windows.Forms.ComboBox();
            this.labelfoldername = new System.Windows.Forms.Label();
            this.foldername = new System.Windows.Forms.TextBox();
            this.nowserverfilebox = new System.Windows.Forms.GroupBox();
            this.serverfile = new System.Windows.Forms.ListBox();
            this.nowfolderbox = new System.Windows.Forms.GroupBox();
            this.serverfolder = new System.Windows.Forms.ListBox();
            this.createserver = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.lavelserverkind = new System.Windows.Forms.Label();
            this.removefile = new System.Windows.Forms.Button();
            this.openfolder = new System.Windows.Forms.Button();
            this.openprofiles = new System.Windows.Forms.Button();
            this.openworld = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.createshortcut = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.nowserverfilebox.SuspendLayout();
            this.nowfolderbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serversel
            // 
            resources.ApplyResources(this.serversel, "serversel");
            this.serversel.FormattingEnabled = true;
            this.serversel.Name = "serversel";
            this.serversel.SelectedIndexChanged += new System.EventHandler(this.serversel_SelectedIndexChanged);
            // 
            // labelserverfile
            // 
            resources.ApplyResources(this.labelserverfile, "labelserverfile");
            this.labelserverfile.Name = "labelserverfile";
            // 
            // versel
            // 
            this.versel.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.versel, "versel");
            this.versel.FormattingEnabled = true;
            this.versel.Name = "versel";
            this.versel.SelectedIndexChanged += new System.EventHandler(this.versel_SelectedIndexChanged);
            // 
            // labelfoldername
            // 
            resources.ApplyResources(this.labelfoldername, "labelfoldername");
            this.labelfoldername.Name = "labelfoldername";
            // 
            // foldername
            // 
            resources.ApplyResources(this.foldername, "foldername");
            this.foldername.Name = "foldername";
            // 
            // nowserverfilebox
            // 
            this.nowserverfilebox.BackColor = System.Drawing.SystemColors.Control;
            this.nowserverfilebox.Controls.Add(this.serverfile);
            resources.ApplyResources(this.nowserverfilebox, "nowserverfilebox");
            this.nowserverfilebox.Name = "nowserverfilebox";
            this.nowserverfilebox.TabStop = false;
            // 
            // serverfile
            // 
            resources.ApplyResources(this.serverfile, "serverfile");
            this.serverfile.FormattingEnabled = true;
            this.serverfile.Name = "serverfile";
            // 
            // nowfolderbox
            // 
            this.nowfolderbox.Controls.Add(this.serverfolder);
            resources.ApplyResources(this.nowfolderbox, "nowfolderbox");
            this.nowfolderbox.Name = "nowfolderbox";
            this.nowfolderbox.TabStop = false;
            // 
            // serverfolder
            // 
            this.serverfolder.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.serverfolder, "serverfolder");
            this.serverfolder.FormattingEnabled = true;
            this.serverfolder.Name = "serverfolder";
            this.serverfolder.SelectedIndexChanged += new System.EventHandler(this.serverfolder_SelectedIndexChanged);
            // 
            // createserver
            // 
            resources.ApplyResources(this.createserver, "createserver");
            this.createserver.Name = "createserver";
            this.createserver.UseVisualStyleBackColor = true;
            this.createserver.Click += new System.EventHandler(this.createserver_Click);
            // 
            // start
            // 
            resources.ApplyResources(this.start, "start");
            this.start.Name = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // reload
            // 
            resources.ApplyResources(this.reload, "reload");
            this.reload.Name = "reload";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // lavelserverkind
            // 
            resources.ApplyResources(this.lavelserverkind, "lavelserverkind");
            this.lavelserverkind.Name = "lavelserverkind";
            // 
            // removefile
            // 
            resources.ApplyResources(this.removefile, "removefile");
            this.removefile.Name = "removefile";
            this.removefile.UseVisualStyleBackColor = true;
            this.removefile.Click += new System.EventHandler(this.removefile_Click);
            // 
            // openfolder
            // 
            resources.ApplyResources(this.openfolder, "openfolder");
            this.openfolder.Name = "openfolder";
            this.openfolder.UseVisualStyleBackColor = true;
            this.openfolder.Click += new System.EventHandler(this.openfolder_Click);
            // 
            // openprofiles
            // 
            resources.ApplyResources(this.openprofiles, "openprofiles");
            this.openprofiles.Name = "openprofiles";
            this.openprofiles.UseVisualStyleBackColor = true;
            this.openprofiles.Click += new System.EventHandler(this.openprofiles_Click);
            // 
            // openworld
            // 
            resources.ApplyResources(this.openworld, "openworld");
            this.openworld.Name = "openworld";
            this.openworld.UseVisualStyleBackColor = true;
            this.openworld.Click += new System.EventHandler(this.openworld_Click);
            // 
            // exit
            // 
            resources.ApplyResources(this.exit, "exit");
            this.exit.Name = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // createshortcut
            // 
            resources.ApplyResources(this.createshortcut, "createshortcut");
            this.createshortcut.Name = "createshortcut";
            this.createshortcut.UseVisualStyleBackColor = true;
            this.createshortcut.Click += new System.EventHandler(this.createshortcut_Click);
            // 
            // folderBrowserDialog
            // 
            // 
            // mainform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ControlBox = false;
            this.Controls.Add(this.createshortcut);
            this.Controls.Add(this.openfolder);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.labelfoldername);
            this.Controls.Add(this.openworld);
            this.Controls.Add(this.openprofiles);
            this.Controls.Add(this.removefile);
            this.Controls.Add(this.labelserverfile);
            this.Controls.Add(this.lavelserverkind);
            this.Controls.Add(this.nowfolderbox);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.start);
            this.Controls.Add(this.createserver);
            this.Controls.Add(this.nowserverfilebox);
            this.Controls.Add(this.foldername);
            this.Controls.Add(this.versel);
            this.Controls.Add(this.serversel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.nowserverfilebox.ResumeLayout(false);
            this.nowfolderbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serversel;
        private System.Windows.Forms.Label labelserverfile;
        private System.Windows.Forms.TextBox foldername;
        private System.Windows.Forms.Label labelfoldername;
        private System.Windows.Forms.GroupBox nowfolderbox;
        private System.Windows.Forms.GroupBox nowserverfilebox;
        private System.Windows.Forms.Button createserver;
        private System.Windows.Forms.ListBox serverfolder;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.ComboBox versel;
        private System.Windows.Forms.Label lavelserverkind;
        private System.Windows.Forms.ListBox serverfile;
        private System.Windows.Forms.Button openfolder;
        private System.Windows.Forms.Button removefile;
        private System.Windows.Forms.Button openprofiles;
        private System.Windows.Forms.Button openworld;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button createshortcut;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

