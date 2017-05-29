using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TransportationInvoice.LogicClasses;
namespace TransportationInvoice.Forms
{
    public partial class frmProjects : Form
    {
        int IsNew = 0, isUpdate = 0, IDGD = 0;
        public frmProjects()
        {
            InitializeComponent();
        }
        private void disablecontrol(bool t)
        {

            foreach (Control c in groupControl2.Controls)
            {

                c.Enabled = t;

            }
        }
        private void Clear()
        {

            foreach (Control c in groupControl2.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }

        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                {
                    int slrow = gridView1.GetSelectedRows()[i];
                    IDGD = int.Parse(gridView1.GetRowCellValue(slrow, gridView1.Columns["ID"]).ToString());
                    DataConfig clsget = new DataConfig();
                    DataTable _mdt = clsget.getTable("select * from [PROJECTS] where id='" + IDGD.ToString() + "'");
                    if (_mdt != null && _mdt.Rows.Count > 0)
                    {

                        txtID.Text = _mdt.Rows[0]["id"].ToString();
                        txtProjectcode.Text = _mdt.Rows[0]["ProjectCode"].ToString();
                        txtProjectName.Text = _mdt.Rows[0]["ProjectName"].ToString();
                        txtNote.Text = _mdt.Rows[0]["PrjDesc"].ToString();
                      

                        btnDel.Enabled = true;
                        btnSave.Enabled = true;
                        IsNew = 0; isUpdate = 1;
                        disablecontrol(true);
                    }
                }
            }
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            detailViewContextMenuStrip.Show(MousePosition);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDel.Enabled = false;
            IsNew = 1;
            isUpdate = 0; IDGD = 0;
            Clear();
            disablecontrol(true);           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupControl2.Controls)
            {
                if (c.GetType() == typeof(TextBox) && c.Text == "")
                {
                    if (c.Name.IndexOf("txtID") == -1)
                    {
                        MessageBox.Show("すべての情報を入力してください!");
                        c.Focus();
                        return;
                    }
                }
            }
            string StoreName = "", strconfirm = "";
            if (IsNew == 1)
            {
                StoreName = "SP_INSERT_PROJECTS";
                strconfirm = "追加してよろしいでしょうか??";

            }
            else if (isUpdate == 1)
            {
                StoreName = "SP_UPDATE_PROJECTS";
                strconfirm = "更新してよろしいでしょうか?";
            }
            //    #region
            DialogResult result = MessageBox.Show(strconfirm, "確認", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                DataConfig clins = new DataConfig();
                string SQL = "exec " + StoreName + " " + IDGD.ToString() + ",N'" + txtProjectcode.Text.ToString() + "',N'" + txtProjectName.Text + "',N'" + txtNote.Text + "'";
                clins.Excute(SQL);

                Clear();
                btnSave.Enabled = false;
                btnDel.Enabled = false;
                GENPROJECTS();
                IDGD = 0;
                MessageBox.Show("更新しました。");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("削除してもよろしいですか?", "確認", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DataConfig clins = new DataConfig();
                string SQL = "exec SP_DELETE_PROJECT " + IDGD.ToString();
                clins.Excute(SQL);

                Clear();
                btnSave.Enabled = false;
                btnDel.Enabled = false;
                GENPROJECTS();
                IDGD = 0;
                MessageBox.Show("削除しました。");
            }
        }

        private void frmProjects_Load(object sender, EventArgs e)
        {
            disablecontrol(false);
            btnSave.Enabled = false;
            btnDel.Enabled = false;
            GENPROJECTS();
        }
        void GENPROJECTS()
        {
            gridControl1.DataSource = null;
            gridControl1.Refresh();
            DataConfig clsdt = new DataConfig();

            DataTable _mdata = clsdt.getTable("select [ID] ,[ProjectCode]  N'プロジェクトコード',[ProjectName] N'プロジェクト名',[PrjDesc] N'詳細' from [dbo].[PROJECTS]"); 
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.DataSource = _mdata;
            gridControl1.Refresh();
            gridView1.Columns[0].Visible = false;

            gridView1.BestFitColumns();
        }

       

        private void txtProjectName_Enter(object sender, EventArgs e)
        {
            txtProjectName.SelectAll();
            txtProjectName.Focus();
        }

        private void txtNote_Enter(object sender, EventArgs e)
        {
            txtNote.SelectAll();
            txtNote.Focus();
        }
        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel Files| *.xls; *.xlsx";
            saveFileDialog1.FileName = "4294_アイン_週間交通費_";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gridView1.BestFitColumns();
                gridView1.OptionsPrint.AutoWidth = false;
                gridView1.ExportToXls(saveFileDialog1.FileName);
                System.Diagnostics.Process.Start(saveFileDialog1.FileName);
            }
        }
        private void ToolStripDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                {
                    int slrow = gridView1.GetSelectedRows()[i];
                    IDGD = int.Parse(gridView1.GetRowCellValue(slrow, gridView1.Columns["ID"]).ToString());
                    DataConfig clsget = new DataConfig();
                    DataTable _mdt = clsget.getTable("select * from [PROJECTS] where id='" + IDGD.ToString() + "'");
                    if (_mdt != null && _mdt.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("削除してもよろしいですか?", "確認", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            DataConfig clins = new DataConfig();
                            string SQL = "exec SP_DELETE_PROJECT " + IDGD.ToString();
                            clins.Excute(SQL);

                            Clear();
                            btnSave.Enabled = false;
                            btnDel.Enabled = false;
                            GENPROJECTS();
                            IDGD = 0;
                            MessageBox.Show("削除しました。");
                        }
                    }
                }
            }
        }
    }
}
