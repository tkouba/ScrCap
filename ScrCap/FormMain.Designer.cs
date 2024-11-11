namespace ScrCap
{
    partial class FormMain
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
            if (disposing)
            {
                timer?.Dispose();
                components?.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTileVert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTileHorz = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButtonCapture = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.menuMain.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.windowsToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(746, 24);
            this.menuMain.TabIndex = 0;
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCapture,
            this.menuItemSave,
            this.menuItemClose,
            this.toolStripMenuItem1,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemCapture
            // 
            this.menuItemCapture.Name = "menuItemCapture";
            this.menuItemCapture.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemCapture.Size = new System.Drawing.Size(186, 22);
            this.menuItemCapture.Text = "&New Capture";
            this.menuItemCapture.Click += new System.EventHandler(this.menuItemCapture_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Enabled = false;
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSave.Size = new System.Drawing.Size(186, 22);
            this.menuItemSave.Text = "&Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Enabled = false;
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuItemClose.Size = new System.Drawing.Size(186, 22);
            this.menuItemClose.Text = "Clos&e";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(186, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCascade,
            this.menuItemTileVert,
            this.menuItemTileHorz,
            this.menuItemArrangeIcons,
            this.menuItemCloseAll});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "&Windows";
            // 
            // menuItemCascade
            // 
            this.menuItemCascade.Name = "menuItemCascade";
            this.menuItemCascade.Size = new System.Drawing.Size(150, 22);
            this.menuItemCascade.Text = "&Cascade";
            this.menuItemCascade.Click += new System.EventHandler(this.menuItemCascade_Click);
            // 
            // menuItemTileVert
            // 
            this.menuItemTileVert.Name = "menuItemTileVert";
            this.menuItemTileVert.Size = new System.Drawing.Size(150, 22);
            this.menuItemTileVert.Text = "Tile &Vertical";
            this.menuItemTileVert.Click += new System.EventHandler(this.menuItemTileVert_Click);
            // 
            // menuItemTileHorz
            // 
            this.menuItemTileHorz.Name = "menuItemTileHorz";
            this.menuItemTileHorz.Size = new System.Drawing.Size(150, 22);
            this.menuItemTileHorz.Text = "Tile &Horizontal";
            this.menuItemTileHorz.Click += new System.EventHandler(this.menuItemTileHorz_Click);
            // 
            // menuItemArrangeIcons
            // 
            this.menuItemArrangeIcons.Name = "menuItemArrangeIcons";
            this.menuItemArrangeIcons.Size = new System.Drawing.Size(150, 22);
            this.menuItemArrangeIcons.Text = "&Arrange Icons";
            this.menuItemArrangeIcons.Click += new System.EventHandler(this.menuItemArrangeIcons_Click);
            // 
            // menuItemCloseAll
            // 
            this.menuItemCloseAll.Name = "menuItemCloseAll";
            this.menuItemCloseAll.Size = new System.Drawing.Size(150, 22);
            this.menuItemCloseAll.Text = "C&lose all";
            this.menuItemCloseAll.Click += new System.EventHandler(this.menuItemCloseAll_Click);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCapture,
            this.toolStripButtonSave});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(746, 25);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 443);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(746, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(731, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripButtonCapture
            // 
            this.toolStripButtonCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCapture.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCapture.Image")));
            this.toolStripButtonCapture.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButtonCapture.Name = "toolStripButtonCapture";
            this.toolStripButtonCapture.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCapture.Text = "New";
            this.toolStripButtonCapture.Click += new System.EventHandler(this.toolStripButtonCapture_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 465);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormMain";
            this.Text = "Screen capture for Android devices";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.FormMain_MdiChildActivate);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemCapture;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemCascade;
        private System.Windows.Forms.ToolStripMenuItem menuItemTileVert;
        private System.Windows.Forms.ToolStripMenuItem menuItemTileHorz;
        private System.Windows.Forms.ToolStripMenuItem menuItemCloseAll;
        private System.Windows.Forms.ToolStripMenuItem menuItemArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemClose;
        private System.Windows.Forms.ToolStripButton toolStripButtonCapture;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
    }
}

