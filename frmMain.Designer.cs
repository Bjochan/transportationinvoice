namespace TransportationInvoice
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stgsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._frmUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this._frmChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this._Close = new System.Windows.Forms.ToolStripMenuItem();
            this.lstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lst_Cus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.dm_DA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bumonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ListKoguchi = new System.Windows.Forms.ToolStripMenuItem();
            this._LKoguchi = new System.Windows.Forms.ToolStripMenuItem();
            this.keiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._About = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // 
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainerControl1.Panel1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Panel1.Name = "";
            this.splitContainerControl1.Panel1.Size = new System.Drawing.Size(1019, 26);
            this.splitContainerControl1.Panel1.TabIndex = 0;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // 
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Panel2.Name = "";
            this.splitContainerControl1.Panel2.Size = new System.Drawing.Size(1019, 479);
            this.splitContainerControl1.Panel2.TabIndex = 1;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1019, 510);
            this.splitContainerControl1.SplitterPosition = 26;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stgsToolStripMenuItem,
            this.lstToolStripMenuItem,
            this._ListKoguchi,
            this.keiroToolStripMenuItem,
            this._About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuMain";
            // 
            // stgsToolStripMenuItem
            // 
            this.stgsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._frmUsers,
            this.toolStripMenuItem1,
            this._frmChangePass,
            this.toolStripMenuItem6,
            this._Close});
            this.stgsToolStripMenuItem.Name = "stgsToolStripMenuItem";
            this.stgsToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.stgsToolStripMenuItem.Text = "設定";
            // 
            // _frmUsers
            // 
            this._frmUsers.Name = "_frmUsers";
            this._frmUsers.Size = new System.Drawing.Size(160, 22);
            this._frmUsers.Text = "従業員管理";
            this._frmUsers.Click += new System.EventHandler(this._frmUsers_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // _frmChangePass
            // 
            this._frmChangePass.Name = "_frmChangePass";
            this._frmChangePass.Size = new System.Drawing.Size(160, 22);
            this._frmChangePass.Text = "パスワード変更";
            this._frmChangePass.Click += new System.EventHandler(this._frmChangePass_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(157, 6);
            // 
            // _Close
            // 
            this._Close.Name = "_Close";
            this._Close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._Close.Size = new System.Drawing.Size(160, 22);
            this._Close.Text = "終了";
            this._Close.Click += new System.EventHandler(this._close_Click);
            // 
            // lstToolStripMenuItem
            // 
            this.lstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lst_Cus,
            this.toolStripMenuItem3,
            this.dm_DA,
            this.toolStripSeparator1,
            this.bumonToolStripMenuItem});
            this.lstToolStripMenuItem.Name = "lstToolStripMenuItem";
            this.lstToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.lstToolStripMenuItem.Text = "リスト";
            // 
            // lst_Cus
            // 
            this.lst_Cus.Name = "lst_Cus";
            this.lst_Cus.Size = new System.Drawing.Size(148, 22);
            this.lst_Cus.Text = "顧客";
            this.lst_Cus.Click += new System.EventHandler(this.list_KH_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // dm_DA
            // 
            this.dm_DA.Name = "dm_DA";
            this.dm_DA.Size = new System.Drawing.Size(148, 22);
            this.dm_DA.Text = "プロジェクト";
            this.dm_DA.Click += new System.EventHandler(this.dm_DA_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // bumonToolStripMenuItem
            // 
            this.bumonToolStripMenuItem.Name = "bumonToolStripMenuItem";
            this.bumonToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.bumonToolStripMenuItem.Text = "部門";
            this.bumonToolStripMenuItem.Click += new System.EventHandler(this.bumonToolStripMenuItem_Click);
            // 
            // _ListKoguchi
            // 
            this._ListKoguchi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._LKoguchi});
            this._ListKoguchi.Name = "_ListKoguchi";
            this._ListKoguchi.Size = new System.Drawing.Size(44, 22);
            this._ListKoguchi.Text = "小口";
            // 
            // _LKoguchi
            // 
            this._LKoguchi.Name = "_LKoguchi";
            this._LKoguchi.Size = new System.Drawing.Size(124, 22);
            this._LKoguchi.Text = "小口編集";
            this._LKoguchi.Click += new System.EventHandler(this._LKoguchi_Click);
            // 
            // keiroToolStripMenuItem
            // 
            this.keiroToolStripMenuItem.Name = "keiroToolStripMenuItem";
            this.keiroToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.keiroToolStripMenuItem.Text = "経路";
            this.keiroToolStripMenuItem.Click += new System.EventHandler(this.keiroToolStripMenuItem_Click);
            // 
            // _About
            // 
            this._About.Name = "_About";
            this._About.Size = new System.Drawing.Size(56, 22);
            this._About.Text = "ヘルプ";
            this._About.Click += new System.EventHandler(this._About_Click);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // 
            // 
            this.splitContainerControl2.Panel1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Panel1.Name = "";
            this.splitContainerControl2.Panel1.Size = new System.Drawing.Size(1019, 446);
            this.splitContainerControl2.Panel1.TabIndex = 0;
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // 
            // 
            this.splitContainerControl2.Panel2.Location = new System.Drawing.Point(0, 451);
            this.splitContainerControl2.Panel2.Name = "";
            this.splitContainerControl2.Panel2.Size = new System.Drawing.Size(1019, 28);
            this.splitContainerControl2.Panel2.TabIndex = 1;
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1019, 479);
            this.splitContainerControl2.SplitterPosition = 28;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 510);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メイン";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stgsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _frmUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem _frmChangePass;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem _Close;
        private System.Windows.Forms.ToolStripMenuItem lstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lst_Cus;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dm_DA;
        private System.Windows.Forms.ToolStripMenuItem _ListKoguchi;
        private System.Windows.Forms.ToolStripMenuItem _LKoguchi;
        private System.Windows.Forms.ToolStripMenuItem _About;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.ToolStripMenuItem keiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem bumonToolStripMenuItem;
    }
}