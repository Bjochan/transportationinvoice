using System;
using System.Data;
using System.Windows.Forms;
using TransportationInvoice.LogicClasses;

namespace TransportationInvoice.Forms
{
    public partial class frmUsers : Form
    {
        int IsNew = 0, isUpdate = 0, IDGD = 0;
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            disablecontrol(false);
            btnSave.Enabled = false;
            btnDel.Enabled = false;
            GENUSERS();
            
            DataConfig clsdt = new DataConfig();
            DataTable _mdata = clsdt.getTable("exec [GET_ALLEMPLOYEE_DETAIL] '" + GlobalVariables.User + "'");
            if (_mdata != null)
            {
                txtID.Text = _mdata.Rows[0]["Employee_id"].ToString();
                txtName.Text = _mdata.Rows[0]["氏名"].ToString();
                txtUser.Text = _mdata.Rows[0]["社員ID"].ToString();
                txtSiteName.Text = _mdata.Rows[0]["サイト名"].ToString();
                chkIsadmin.Checked = true;
                if (_mdata.Rows[0]["IsAdmin"].ToString() == "0")
                    chkIsadmin.Checked = false;
                cmbbumon.Items.Clear();
                clsdt = new DataConfig();
                DataTable _mbumon = clsdt.getTable("select * from BUMON");
                if (_mbumon != null)
                {
                    for (int j = 0; j < _mbumon.Rows.Count; j++)
                    {
                        cmbbumon.Items.Add(new GlobalVariables.Item(_mbumon.Rows[j]["Bumon_Name"].ToString().ToUpper(), _mbumon.Rows[j]["ID"].ToString().ToUpper()));                      
                   
                    }
                    for (int j = 0; j < cmbbumon.Items.Count; j++)
                    {
                          GlobalVariables.Item it = (GlobalVariables.Item)cmbbumon.Items[j];

                            if (it.Value == _mdata.Rows[0]["BUMON_ID"].ToString())
                                cmbbumon.SelectedItem = it;
                    }
                }
            }
            if (GlobalVariables.IsAdmin == 0)
            {
                groupControl1.Visible = false;
                btnSave.Enabled = false;
                btnDel.Enabled = false;
                btnNew.Enabled = false;
                disablecontrol(false);

            }
        }
        void GENUSERS()
        {
            gridControl1.DataSource = null;
            gridControl1.Refresh();
            DataConfig clsdt = new DataConfig();

            DataTable _mdata = clsdt.getTable("exec GET_ALLEMPLOYEE '"+GlobalVariables.User+"'");
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.DataSource = _mdata;
            gridControl1.Refresh();
            gridView1.Columns[0].Visible = false;

            gridView1.BestFitColumns();
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
                    string uname = gridView1.GetRowCellValue(slrow, gridView1.Columns["社員ID"]).ToString();
                    IDGD = int.Parse(gridView1.GetRowCellValue(slrow, gridView1.Columns["Employee_id"]).ToString());
                    DataConfig clsget = new DataConfig();
                    DataTable _mdt = clsget.getTable("GET_ALLEMPLOYEE_DETAIL '" + uname.ToString() + "'");
                    if (_mdt != null && _mdt.Rows.Count > 0)
                    {
                        txtID.Text = _mdt.Rows[0]["Employee_id"].ToString();
                        txtName.Text = _mdt.Rows[0]["氏名"].ToString();
                        txtUser.Text = _mdt.Rows[0]["社員ID"].ToString();
                        txtSiteName.Text = _mdt.Rows[0]["サイト名"].ToString();
                        chkIsadmin.Checked = true;
                        if (_mdt.Rows[0]["IsAdmin"].ToString() == "0")
                            chkIsadmin.Checked = false;
                        cmbbumon.Items.Clear();
                        DataConfig clsdt = new DataConfig();
                        DataTable _mbumon = clsdt.getTable("select * from BUMON");
                        if (_mbumon != null)
                        {
                            for (int j = 0; j < _mbumon.Rows.Count; j++)
                            {
                                cmbbumon.Items.Add(new GlobalVariables.Item(_mbumon.Rows[j]["BUMON_NAME"].ToString().ToUpper(), _mbumon.Rows[j]["id"].ToString().ToUpper()));

                            }
                            for (int j = 0; j < cmbbumon.Items.Count; j++)
                            {
                                GlobalVariables.Item it = (GlobalVariables.Item)cmbbumon.Items[j];

                                if (it.Value == _mdt.Rows[0]["BUMON_ID"].ToString())   //cái bumon id minh bo ko để hiển thị nữa
                                    cmbbumon.SelectedItem = it;
                            }
                        }

                        btnDel.Enabled = true;
                        btnSave.Enabled = true;
                        IsNew = 0; isUpdate = 1;
                        disablecontrol(true);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDel.Enabled = false;
            IsNew = 1;
            isUpdate = 0; IDGD = 0;
            Clear();
            disablecontrol(true);
            if (cmbbumon.Items.Count > 0)
                cmbbumon.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string StoreName = "", strconfirm = "";
            if (IsNew == 1)
            {
                StoreName = "SP_INSERT_USERS";
                strconfirm = "追加してよろしいでしょうか?";
            }
            else if (isUpdate == 1)
            {
                StoreName = "SP_UPDATE_USERS";
                strconfirm = "更新してよろしいでしょうか?";
            }
            //    #region
            DialogResult result = MessageBox.Show(strconfirm, "確認", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                DataConfig clins = new DataConfig();
                int isad =0;
                if (chkIsadmin.Checked==true)
                    isad=1;
                if (cmbbumon.SelectedIndex == -1)
                    cmbbumon.SelectedIndex = 0;
                GlobalVariables.Item it = (GlobalVariables.Item)cmbbumon.SelectedItem;
                
                string SQL = "exec " + StoreName + " " + IDGD.ToString() + ",N'" + txtName.Text.ToString() + "',N'" + txtUser.Text + "',N'" + txtPass.Text + "',N'" + txtSiteName.Text + "'," + it.Value + "," + isad + "";
                clins.Excute(SQL);

                Clear();
                btnSave.Enabled = false;
                btnDel.Enabled = false;
                GENUSERS();
                IDGD = 0;
                MessageBox.Show("追加しました。");
            }
        }

        private void ToolStripDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                {
                    int slrow = gridView1.GetSelectedRows()[i];
                    string uname = gridView1.GetRowCellValue(slrow, gridView1.Columns["Employee_LoginID"]).ToString();
                    IDGD = int.Parse(gridView1.GetRowCellValue(slrow, gridView1.Columns["Employee_id"]).ToString());
                    DataConfig clsget = new DataConfig();
                    DataTable _mdt = clsget.getTable("GET_ALLEMPLOYEE_DETAIL '" + uname.ToString() + "'");
                    if (_mdt != null && _mdt.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("削除してもよろしいですか?", "確認", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            DataConfig clins = new DataConfig();
                            string SQL = "exec SP_DELETE_USERS " + IDGD.ToString() + ",'" + uname + "'";
                            clins.Excute(SQL);
                            Clear();
                            btnSave.Enabled = false;
                            btnDel.Enabled = false;
                            GENUSERS();
                            IDGD = 0;
                            MessageBox.Show("削除しました。");
                        }
                    }
                }
            }
        }

        //private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    saveFileDialog1.Filter = "Excel Files| *.xls; *.xlsx";
        //    saveFileDialog1.FileName = "4294_アイン_週間交通費_";
        //    saveFileDialog1.RestoreDirectory = true;
        //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        gridView1.BestFitColumns();
        //        gridView1.OptionsPrint.AutoWidth = false;
        //        gridView1.ExportToXls(saveFileDialog1.FileName);
        //        System.Diagnostics.Process.Start(saveFileDialog1.FileName);
        //    }
        //}

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            detailViewContextMenuStrip.Show(MousePosition);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("削除してもよろしいですか?", "確認", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DataConfig clins = new DataConfig();
                string SQL = "exec SP_DELETE_USERS " + IDGD.ToString()+",'"+txtUser.Text+"'";
                clins.Excute(SQL);

                Clear();
                btnSave.Enabled = false;
                btnDel.Enabled = false;
                GENUSERS();
                IDGD = 0;
                MessageBox.Show("削除しました。");
            }
        }
    }
}
