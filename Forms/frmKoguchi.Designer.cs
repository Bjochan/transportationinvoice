using System.Drawing;

namespace TransportationInvoice.Forms
{
    partial class frmKoguchi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKoguchi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtKoguchiId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmploy = new System.Windows.Forms.ComboBox();
            this.lbprojectname = new System.Windows.Forms.Label();
            this.txtProjectCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCusname = new System.Windows.Forms.Label();
            this.lbEmployName = new System.Windows.Forms.Label();
            this.RegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtemployID_Search = new System.Windows.Forms.TextBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtSearch_to = new System.Windows.Forms.DateTimePicker();
            this.txtSearch_from = new System.Windows.Forms.DateTimePicker();
            this.detailViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.detailViewContextMenuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(225, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 14);
            this.labelControl1.TabIndex = 71;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtKoguchiId);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.cmbEmploy);
            this.groupControl2.Controls.Add(this.lbprojectname);
            this.groupControl2.Controls.Add(this.txtProjectCode);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.lblCusname);
            this.groupControl2.Controls.Add(this.lbEmployName);
            this.groupControl2.Controls.Add(this.RegisterDate);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.txtCustID);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(277, 163);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "情報";
            // 
            // txtKoguchiId
            // 
            this.txtKoguchiId.Location = new System.Drawing.Point(104, 24);
            this.txtKoguchiId.Name = "txtKoguchiId";
            this.txtKoguchiId.ReadOnly = true;
            this.txtKoguchiId.Size = new System.Drawing.Size(148, 19);
            this.txtKoguchiId.TabIndex = 83;
            this.txtKoguchiId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 84;
            this.label3.Text = "KoguchiID:";
            this.label3.Visible = false;
            // 
            // cmbEmploy
            // 
            this.cmbEmploy.FormattingEnabled = true;
            this.cmbEmploy.Location = new System.Drawing.Point(105, 78);
            this.cmbEmploy.Name = "cmbEmploy";
            this.cmbEmploy.Size = new System.Drawing.Size(148, 20);
            this.cmbEmploy.TabIndex = 2;
            this.cmbEmploy.SelectedIndexChanged += new System.EventHandler(this.cmbEmploy_SelectedIndexChanged);
            // 
            // lbprojectname
            // 
            this.lbprojectname.AutoSize = true;
            this.lbprojectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprojectname.Location = new System.Drawing.Point(261, 136);
            this.lbprojectname.Name = "lbprojectname";
            this.lbprojectname.Size = new System.Drawing.Size(81, 13);
            this.lbprojectname.TabIndex = 80;
            this.lbprojectname.Text = "プロジェクト名:";
            this.lbprojectname.Visible = false;
            // 
            // txtProjectCode
            // 
            this.txtProjectCode.Location = new System.Drawing.Point(106, 132);
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.Size = new System.Drawing.Size(148, 19);
            this.txtProjectCode.TabIndex = 4;
            this.txtProjectCode.Leave += new System.EventHandler(this.txtProjectCode_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 78;
            this.label7.Text = "プロジェクトコード:";
            // 
            // lbtenKH
            // 
            this.lblCusname.AutoSize = true;
            this.lblCusname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusname.Location = new System.Drawing.Point(260, 108);
            this.lblCusname.Name = "lbtenKH";
            this.lblCusname.Size = new System.Drawing.Size(46, 13);
            this.lblCusname.TabIndex = 77;
            this.lblCusname.Text = "顧客名";
            this.lblCusname.Visible = false;
            // 
            // lbEmployName
            // 
            this.lbEmployName.AutoSize = true;
            this.lbEmployName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployName.Location = new System.Drawing.Point(259, 80);
            this.lbEmployName.Name = "lbEmployName";
            this.lbEmployName.Size = new System.Drawing.Size(33, 13);
            this.lbEmployName.TabIndex = 75;
            this.lbEmployName.Text = "氏名";
            this.lbEmployName.Visible = false;
            // 
            // RegisterDate
            // 
            this.RegisterDate.CustomFormat = "yyyy/MM/dd";
            this.RegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RegisterDate.Location = new System.Drawing.Point(105, 51);
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.Size = new System.Drawing.Size(108, 19);
            this.RegisterDate.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 12);
            this.label8.TabIndex = 58;
            this.label8.Text = "　社員ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 12);
            this.label9.TabIndex = 60;
            this.label9.Text = "　起案日:";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(105, 106);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(148, 19);
            this.txtCustID.TabIndex = 3;
            this.txtCustID.Leave += new System.EventHandler(this.txtCustID_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "顧客コード:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "社員ID: ";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(703, 135);
            this.gridControl2.TabIndex = 29;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            this.gridView2.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView2_PopupMenuShowing);
            this.gridView2.OptionsView.ShowGroupPanel = false;    //remove text "Drag a column header here to group by that column"

            //set header datagrid color 
            gridControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            gridControl2.LookAndFeel.UseDefaultLookAndFeel = false; // <<<<<<<<
            gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            gridView2.Appearance.HeaderPanel.BackColor = Color.LightGray;

            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "終了日: ";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(605, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 21);
            this.btnsearch.TabIndex = 23;
            this.btnsearch.Text = "検索";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "開始日: ";
            // 
            // txtemployID_Search
            // 
            this.txtemployID_Search.Location = new System.Drawing.Point(439, 4);
            this.txtemployID_Search.Name = "txtemployID_Search";
            this.txtemployID_Search.Size = new System.Drawing.Size(147, 19);
            this.txtemployID_Search.TabIndex = 22;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.splitContainer3);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(707, 188);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "リスト";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(2, 22);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtSearch_to);
            this.splitContainer3.Panel1.Controls.Add(this.txtSearch_from);
            this.splitContainer3.Panel1.Controls.Add(this.txtemployID_Search);
            this.splitContainer3.Panel1.Controls.Add(this.label12);
            this.splitContainer3.Panel1.Controls.Add(this.label11);
            this.splitContainer3.Panel1.Controls.Add(this.btnsearch);
            this.splitContainer3.Panel1.Controls.Add(this.label10);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gridControl2);
            this.splitContainer3.Size = new System.Drawing.Size(703, 164);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 1;
            // 
            // txtSearch_to
            // 
            this.txtSearch_to.CustomFormat = "yyyy/MM/dd";
            this.txtSearch_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtSearch_to.Location = new System.Drawing.Point(249, 3);
            this.txtSearch_to.Name = "txtSearch_to";
            this.txtSearch_to.Size = new System.Drawing.Size(108, 19);
            this.txtSearch_to.TabIndex = 25;
            // 
            // txtSearch_from
            // 
            this.txtSearch_from.CustomFormat = "yyyy/MM/dd";
            this.txtSearch_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtSearch_from.Location = new System.Drawing.Point(75, 5);
            this.txtSearch_from.Name = "txtSearch_from";
            this.txtSearch_from.Size = new System.Drawing.Size(92, 19);
            this.txtSearch_from.TabIndex = 24;
            // 
            // detailViewContextMenuStrip
            // 
            this.detailViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.ToolStripDelete});
            this.detailViewContextMenuStrip.Name = "detailViewContextMenuStrip";
            this.detailViewContextMenuStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem2.Text = "追加";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ToolStripDelete
            // 
            this.ToolStripDelete.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripDelete.Image")));
            this.ToolStripDelete.Name = "ToolStripDelete";
            this.ToolStripDelete.Size = new System.Drawing.Size(100, 22);
            this.ToolStripDelete.Text = "削除";
            this.ToolStripDelete.Click += new System.EventHandler(this.ToolStripDelete_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItem1.Text = "Excelへのエクスポート";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "detailViewContextMenuStrip";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 48);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItem3.Text = "削除";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            // 
            // 
            // 
            this.splitContainerControl3.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl3.Panel1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Panel1.Name = "";
            this.splitContainerControl3.Panel1.Size = new System.Drawing.Size(277, 163);
            this.splitContainerControl3.Panel1.TabIndex = 0;
            this.splitContainerControl3.Panel1.Text = "Panel1";
            // 
            // 
            // 
            this.splitContainerControl3.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl3.Panel2.Location = new System.Drawing.Point(282, 0);
            this.splitContainerControl3.Panel2.Name = "";
            this.splitContainerControl3.Panel2.Size = new System.Drawing.Size(425, 163);
            this.splitContainerControl3.Panel2.TabIndex = 1;
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(707, 163);
            this.splitContainerControl3.SplitterPosition = 277;
            this.splitContainerControl3.TabIndex = 0;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(425, 163);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "詳細";
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(2, 22);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(421, 139);
            this.gridControl3.TabIndex = 30;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView3_RowClick);
            this.gridView3.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView3_PopupMenuShowing);
            this.gridView3.OptionsView.ShowGroupPanel = false;    //remove text "Drag a column header here to group by that column"

            //set header datagrid color 
            gridControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            gridControl3.LookAndFeel.UseDefaultLookAndFeel = false; // <<<<<<<<
            gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
            gridView3.Appearance.HeaderPanel.BackColor = Color.LightGray;
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
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // 
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Panel1.Name = "";
            this.splitContainerControl1.Panel1.Size = new System.Drawing.Size(707, 199);
            this.splitContainerControl1.Panel1.TabIndex = 0;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // 
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel2.Location = new System.Drawing.Point(0, 204);
            this.splitContainerControl1.Panel2.Name = "";
            this.splitContainerControl1.Panel2.Size = new System.Drawing.Size(707, 188);
            this.splitContainerControl1.Panel2.TabIndex = 1;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(707, 392);
            this.splitContainerControl1.SplitterPosition = 199;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // 
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainerControl2.Panel1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Panel1.Name = "";
            this.splitContainerControl2.Panel1.Size = new System.Drawing.Size(707, 31);
            this.splitContainerControl2.Panel1.TabIndex = 0;
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // 
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl2.Panel2.Location = new System.Drawing.Point(0, 36);
            this.splitContainerControl2.Panel2.Name = "";
            this.splitContainerControl2.Panel2.Size = new System.Drawing.Size(707, 163);
            this.splitContainerControl2.Panel2.TabIndex = 1;
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(707, 199);
            this.splitContainerControl2.SplitterPosition = 31;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(16, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.btnDel,
            this.btnExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 27);
            this.toolStrip1.TabIndex = 1;
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
            // btnExporttoExcel
            // 
            this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(23, 24);
            this.btnExcel.Text = "Excelへのエクスポート";
            this.btnExcel.Click += new System.EventHandler(this.btnExporttoExcel_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(303, 111);
            this.gridControl1.TabIndex = 31;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 81;
            this.label2.Text = "トータル:";
            this.label2.Visible = false;
            // 
            // frmKoguchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 392);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmKoguchi";
            this.Text = "交通費請求編集";
            this.Load += new System.EventHandler(this.frmKoguchi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.detailViewContextMenuStrip.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtemployID_Search;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DateTimePicker txtSearch_to;
        private System.Windows.Forms.DateTimePicker txtSearch_from;
        private System.Windows.Forms.ContextMenuStrip detailViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.Label lbprojectname;
        private System.Windows.Forms.TextBox txtProjectCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCusname;
        private System.Windows.Forms.Label lbEmployName;
        private System.Windows.Forms.DateTimePicker RegisterDate;
        private System.Windows.Forms.ComboBox cmbEmploy;
        private System.Windows.Forms.TextBox txtKoguchiId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label2;
    }
}