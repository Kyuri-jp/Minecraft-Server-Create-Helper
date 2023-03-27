namespace C__s_Server_Launcher_GUI
{
    partial class GUI
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
            this.components = new System.ComponentModel.Container();
            this.serversel = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.labelserverfile = new System.Windows.Forms.Label();
            this.versel = new System.Windows.Forms.ComboBox();
            this.labelfoldername = new System.Windows.Forms.Label();
            this.foldername = new System.Windows.Forms.TextBox();
            this.nowserverfilebox = new System.Windows.Forms.GroupBox();
            this.serverfile = new System.Windows.Forms.ListBox();
            this.nowfolderbox = new System.Windows.Forms.GroupBox();
            this.serverfolder = new System.Windows.Forms.ListBox();
            this.createserver = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.start = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lavelserverkind = new System.Windows.Forms.Label();
            this.removefile = new System.Windows.Forms.Button();
            this.openfolder = new System.Windows.Forms.Button();
            this.openprofiles = new System.Windows.Forms.Button();
            this.openworld = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.nowserverfilebox.SuspendLayout();
            this.nowfolderbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // serversel
            // 
            this.serversel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serversel.FormattingEnabled = true;
            this.serversel.Location = new System.Drawing.Point(18, 22);
            this.serversel.Name = "serversel";
            this.serversel.Size = new System.Drawing.Size(277, 39);
            this.serversel.TabIndex = 0;
            this.serversel.SelectedIndexChanged += new System.EventHandler(this.serversel_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // labelserverfile
            // 
            this.labelserverfile.AutoSize = true;
            this.labelserverfile.Font = new System.Drawing.Font("Yu Gothic UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelserverfile.Location = new System.Drawing.Point(301, 98);
            this.labelserverfile.Name = "labelserverfile";
            this.labelserverfile.Size = new System.Drawing.Size(304, 62);
            this.labelserverfile.TabIndex = 2;
            this.labelserverfile.Text = "サーバーファイル";
            // 
            // versel
            // 
            this.versel.BackColor = System.Drawing.SystemColors.Window;
            this.versel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.versel.FormattingEnabled = true;
            this.versel.Location = new System.Drawing.Point(18, 108);
            this.versel.Name = "versel";
            this.versel.Size = new System.Drawing.Size(277, 39);
            this.versel.TabIndex = 3;
            this.versel.SelectedIndexChanged += new System.EventHandler(this.versel_SelectedIndexChanged);
            // 
            // labelfoldername
            // 
            this.labelfoldername.AutoSize = true;
            this.labelfoldername.Font = new System.Drawing.Font("Yu Gothic UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelfoldername.Location = new System.Drawing.Point(301, 182);
            this.labelfoldername.Name = "labelfoldername";
            this.labelfoldername.Size = new System.Drawing.Size(445, 62);
            this.labelfoldername.TabIndex = 5;
            this.labelfoldername.Text = "サーバーフォルダの名前";
            // 
            // foldername
            // 
            this.foldername.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.foldername.Location = new System.Drawing.Point(18, 194);
            this.foldername.Name = "foldername";
            this.foldername.Size = new System.Drawing.Size(277, 38);
            this.foldername.TabIndex = 6;
            // 
            // nowserverfilebox
            // 
            this.nowserverfilebox.BackColor = System.Drawing.SystemColors.Control;
            this.nowserverfilebox.Controls.Add(this.serverfile);
            this.nowserverfilebox.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nowserverfilebox.Location = new System.Drawing.Point(899, 22);
            this.nowserverfilebox.Name = "nowserverfilebox";
            this.nowserverfilebox.Size = new System.Drawing.Size(639, 401);
            this.nowserverfilebox.TabIndex = 7;
            this.nowserverfilebox.TabStop = false;
            this.nowserverfilebox.Text = "現在あるサーバーファイル";
            // 
            // serverfile
            // 
            this.serverfile.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serverfile.FormattingEnabled = true;
            this.serverfile.ItemHeight = 45;
            this.serverfile.Location = new System.Drawing.Point(6, 32);
            this.serverfile.Name = "serverfile";
            this.serverfile.Size = new System.Drawing.Size(623, 364);
            this.serverfile.TabIndex = 0;
            // 
            // nowfolderbox
            // 
            this.nowfolderbox.Controls.Add(this.serverfolder);
            this.nowfolderbox.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nowfolderbox.Location = new System.Drawing.Point(12, 247);
            this.nowfolderbox.Name = "nowfolderbox";
            this.nowfolderbox.Size = new System.Drawing.Size(836, 544);
            this.nowfolderbox.TabIndex = 8;
            this.nowfolderbox.TabStop = false;
            this.nowfolderbox.Text = "現在あるフォルダ";
            // 
            // serverfolder
            // 
            this.serverfolder.BackColor = System.Drawing.SystemColors.Menu;
            this.serverfolder.Font = new System.Drawing.Font("Yu Gothic UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serverfolder.FormattingEnabled = true;
            this.serverfolder.ItemHeight = 59;
            this.serverfolder.Location = new System.Drawing.Point(6, 53);
            this.serverfolder.Name = "serverfolder";
            this.serverfolder.Size = new System.Drawing.Size(824, 476);
            this.serverfolder.TabIndex = 0;
            this.serverfolder.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // createserver
            // 
            this.createserver.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createserver.Location = new System.Drawing.Point(900, 532);
            this.createserver.Name = "createserver";
            this.createserver.Size = new System.Drawing.Size(213, 78);
            this.createserver.TabIndex = 9;
            this.createserver.Text = "サーバー作成!";
            this.createserver.UseVisualStyleBackColor = true;
            this.createserver.Click += new System.EventHandler(this.button1_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.start.Location = new System.Drawing.Point(900, 448);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(213, 78);
            this.start.TabIndex = 10;
            this.start.Text = "サーバー起動!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // reload
            // 
            this.reload.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reload.Location = new System.Drawing.Point(900, 616);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(213, 78);
            this.reload.TabIndex = 11;
            this.reload.Text = "再読み込み";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // lavelserverkind
            // 
            this.lavelserverkind.AutoSize = true;
            this.lavelserverkind.Font = new System.Drawing.Font("Yu Gothic UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lavelserverkind.Location = new System.Drawing.Point(301, 9);
            this.lavelserverkind.Name = "lavelserverkind";
            this.lavelserverkind.Size = new System.Drawing.Size(300, 62);
            this.lavelserverkind.TabIndex = 14;
            this.lavelserverkind.Text = "サーバーの種類";
            // 
            // removefile
            // 
            this.removefile.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.removefile.Location = new System.Drawing.Point(899, 700);
            this.removefile.Name = "removefile";
            this.removefile.Size = new System.Drawing.Size(213, 78);
            this.removefile.TabIndex = 15;
            this.removefile.Text = "削除";
            this.removefile.UseVisualStyleBackColor = true;
            this.removefile.Click += new System.EventHandler(this.removefile_Click);
            // 
            // openfolder
            // 
            this.openfolder.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.openfolder.Location = new System.Drawing.Point(1119, 448);
            this.openfolder.Name = "openfolder";
            this.openfolder.Size = new System.Drawing.Size(213, 78);
            this.openfolder.TabIndex = 16;
            this.openfolder.Text = "フォルダを開く";
            this.openfolder.UseVisualStyleBackColor = true;
            this.openfolder.Click += new System.EventHandler(this.openfolder_Click);
            // 
            // openprofiles
            // 
            this.openprofiles.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.openprofiles.Location = new System.Drawing.Point(1119, 532);
            this.openprofiles.Name = "openprofiles";
            this.openprofiles.Size = new System.Drawing.Size(213, 78);
            this.openprofiles.TabIndex = 17;
            this.openprofiles.Text = "server.propertiesを開く";
            this.openprofiles.UseVisualStyleBackColor = true;
            this.openprofiles.Click += new System.EventHandler(this.openprofiles_Click);
            // 
            // openworld
            // 
            this.openworld.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.openworld.Location = new System.Drawing.Point(1119, 614);
            this.openworld.Name = "openworld";
            this.openworld.Size = new System.Drawing.Size(213, 78);
            this.openworld.TabIndex = 18;
            this.openworld.Text = "ワールドフォルダを開く";
            this.openworld.UseVisualStyleBackColor = true;
            this.openworld.Click += new System.EventHandler(this.openworld_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exit.Location = new System.Drawing.Point(1119, 698);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(213, 78);
            this.exit.TabIndex = 19;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1678, 803);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.labelfoldername);
            this.Controls.Add(this.openworld);
            this.Controls.Add(this.openprofiles);
            this.Controls.Add(this.openfolder);
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
            this.Font = new System.Drawing.Font("Yu Gothic UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUI";
            this.Text = "Server Create Application";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.nowserverfilebox.ResumeLayout(false);
            this.nowfolderbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serversel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label labelserverfile;
        private System.Windows.Forms.TextBox foldername;
        private System.Windows.Forms.Label labelfoldername;
        private System.Windows.Forms.GroupBox nowfolderbox;
        private System.Windows.Forms.GroupBox nowserverfilebox;
        private System.Windows.Forms.Button createserver;
        private System.Windows.Forms.ListBox serverfolder;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox versel;
        private System.Windows.Forms.Label lavelserverkind;
        private System.Windows.Forms.ListBox serverfile;
        private System.Windows.Forms.Button openfolder;
        private System.Windows.Forms.Button removefile;
        private System.Windows.Forms.Button openprofiles;
        private System.Windows.Forms.Button openworld;
        private System.Windows.Forms.Button exit;
    }
}

