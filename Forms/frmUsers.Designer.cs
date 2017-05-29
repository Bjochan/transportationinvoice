using System.Drawing;

namespace TransportationInvoice.Forms
{
    partial class frmUsers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chkIsadmin = new System.Windows.Forms.CheckBox();
            this.cmbbumon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.RegisterDate = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.detailViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.detailViewContextMenuStrip.SuspendLayout();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainerControl1.Panel1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Panel1.Name = "";
            this.splitContainerControl1.Panel1.Size = new System.Drawing.Size(885, 30);
            this.splitContainerControl1.Panel1.TabIndex = 0;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // 
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Location = new System.Drawing.Point(0, 35);
            this.splitContainerControl1.Panel2.Name = "";
            this.splitContainerControl1.Panel2.Size = new System.Drawing.Size(885, 418);
            this.splitContainerControl1.Panel2.TabIndex = 1;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(885, 453);
            this.splitContainerControl1.SplitterPosition = 30;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(16, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.btnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(885, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 24);
            this.btnNew.Text = "新規";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 24);
            this.btnSave.Text = "保存/更新";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(23, 24);
            this.btnDel.Text = "削除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // 
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Panel1.Name = "";
            this.splitContainerControl2.Panel1.Size = new System.Drawing.Size(342, 418);
            this.splitContainerControl2.Panel1.TabIndex = 0;
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // 
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel2.Location = new System.Drawing.Point(347, 0);
            this.splitContainerControl2.Panel2.Name = "";
            this.splitContainerControl2.Panel2.Size = new System.Drawing.Size(538, 418);
            this.splitContainerControl2.Panel2.TabIndex = 1;
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(885, 418);
            this.splitContainerControl2.SplitterPosition = 342;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.chkIsadmin);
            this.groupControl2.Controls.Add(this.cmbbumon);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.txtSiteName);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txtPass);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txtUser);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txtName);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.txtID);
            this.groupControl2.Controls.Add(this.RegisterDate);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(342, 421);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "社員情報";
            this.groupControl2.Visible = false;
            // 
            // chkIsadmin
            // 
            this.chkIsadmin.AutoSize = true;
            this.chkIsadmin.Location = new System.Drawing.Point(109, 258);
            this.chkIsadmin.Name = "chkIsadmin";
            this.chkIsadmin.Size = new System.Drawing.Size(86, 16);
            this.chkIsadmin.TabIndex = 85;
            this.chkIsadmin.Text = "管理者として";
            this.chkIsadmin.UseVisualStyleBackColor = true;
            // 
            // cmbbumon
            // 
            this.cmbbumon.FormattingEnabled = true;
            this.cmbbumon.Location = new System.Drawing.Point(109, 184);
            this.cmbbumon.Name = "cmbbumon";
            this.cmbbumon.Size = new System.Drawing.Size(180, 20);
            this.cmbbumon.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 82;
            this.label6.Text = "部門:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 81;
            this.label5.Text = "サイト名:";
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(109, 222);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(180, 19);
            this.txtSiteName.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 79;
            this.label4.Text = "パスワード:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(109, 145);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(180, 19);
            this.txtPass.TabIndex = 78;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 77;
            this.label3.Text = "社員ID:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(109, 108);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(180, 19);
            this.txtUser.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 75;
            this.label2.Text = "社員名:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 19);
            this.txtName.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 12);
            this.label1.TabIndex = 73;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(109, 38);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(180, 19);
            this.txtID.TabIndex = 72;
            this.txtID.Visible = false;
            // 
            // RegisterDate
            // 
            this.RegisterDate.CustomFormat = "dd/MM/yyyy";
            this.RegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RegisterDate.Location = new System.Drawing.Point(368, 38);
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.Size = new System.Drawing.Size(108, 19);
            this.RegisterDate.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(225, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 14);
            this.labelControl1.TabIndex = 71;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(538, 418);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "従業員リスト";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(534, 394);
            this.gridControl1.TabIndex = 32;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            this.gridView1.OptionsView.ShowGroupPanel = false;    //remove text "Drag a column header here to group by that column"

            //set header datagrid color 
            gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            gridControl1.LookAndFeel.UseDefaultLookAndFeel = false; // <<<<<<<<
            gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            gridView1.Appearance.HeaderPanel.BackColor = Color.LightGray;
            // 
            // detailViewContextMenuStrip
            // 
            this.detailViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDelete,
            this.exportToExcelToolStripMenuItem});
            this.detailViewContextMenuStrip.Name = "detailViewContextMenuStrip";
            this.detailViewContextMenuStrip.Size = new System.Drawing.Size(203, 48);
            // 
            // ToolStripDelete
            // 
            this.ToolStripDelete.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripDelete.Image")));
            this.ToolStripDelete.Name = "ToolStripDelete";
            this.ToolStripDelete.Size = new System.Drawing.Size(202, 22);
            this.ToolStripDelete.Text = "削除";
            this.ToolStripDelete.Click += new System.EventHandler(this.ToolStripDelete_Click);
            // 
            // exportToExcelToolStripMenuItem
            // 
            //this.exportToExcelToolStripMenuItem.Image = global::TransportationInvoice.Properties.Resources.excel;
            //this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            //this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            //this.exportToExcelToolStripMenuItem.Text = "Excelへのエクスポート";
            //this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 453);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmUsers";
            this.Text = "従業員詳細";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.detailViewContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnDel;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DateTimePicker RegisterDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.CheckBox chkIsadmin;
        private System.Windows.Forms.ComboBox cmbbumon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip detailViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripDelete;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;

    }
}