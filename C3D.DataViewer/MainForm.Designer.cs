namespace C3D.DataViewer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tvItems = new System.Windows.Forms.TreeView();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLine = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przeładujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijBadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.ssMain.Location = new System.Drawing.Point(0, 532);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(884, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 24);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tvItems);
            this.scMain.Size = new System.Drawing.Size(884, 508);
            this.scMain.SplitterDistance = 250;
            this.scMain.SplitterWidth = 1;
            this.scMain.TabIndex = 2;
            // 
            // tvItems
            // 
            this.tvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvItems.FullRowSelect = true;
            this.tvItems.Location = new System.Drawing.Point(0, 0);
            this.tvItems.Name = "tvItems";
            this.tvItems.Size = new System.Drawing.Size(250, 508);
            this.tvItems.TabIndex = 0;
            this.tvItems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvItems_AfterSelect);
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "c3d";
            this.dlgOpen.Filter = "C3D File(*.c3d)|*.c3d";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.wczytajToolStripMenuItem,
            this.przeładujToolStripMenuItem,
            this.zamknijBadanieToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(884, 24);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLine,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "&Plik";
            // 
            // mnuLine
            // 
            this.mnuLine.Name = "mnuLine";
            this.mnuLine.Size = new System.Drawing.Size(156, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeyDisplayString = "Alt+F4";
            this.mnuExit.Size = new System.Drawing.Size(159, 22);
            this.mnuExit.Text = "Zamknij";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.wczytajToolStripMenuItem.Text = "&Wczytaj";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // przeładujToolStripMenuItem
            // 
            this.przeładujToolStripMenuItem.Name = "przeładujToolStripMenuItem";
            this.przeładujToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.przeładujToolStripMenuItem.Text = "&Odśwież";
            this.przeładujToolStripMenuItem.Click += new System.EventHandler(this.przeładujToolStripMenuItem_Click);
            // 
            // zamknijBadanieToolStripMenuItem
            // 
            this.zamknijBadanieToolStripMenuItem.Name = "zamknijBadanieToolStripMenuItem";
            this.zamknijBadanieToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.zamknijBadanieToolStripMenuItem.Text = "&Zamknij badanie";
            this.zamknijBadanieToolStripMenuItem.Click += new System.EventHandler(this.zamknijBadanieToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 554);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.mnuMain);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMG Analisys";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TreeView tvItems;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator mnuLine;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przeładujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijBadanieToolStripMenuItem;
    }
}

