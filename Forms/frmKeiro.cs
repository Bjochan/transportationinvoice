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
    public partial class frmKeiro : Form
    {
        int IsNew = 0, isUpdate = 0, IDGD = 0;
        public frmKeiro()
        {
            InitializeComponent();
        }
        DataView dtv = new DataView();
        //DataTable _mcus;
        //DataTable _mTK;
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDel.Enabled = false;
            IsNew = 1;
            isUpdate = 0; IDGD = 0;
            Clear();
            disablecontrol(true);
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
        void GENKEIRO()
        {
            gridControl1.DataSource = null;
            gridControl1.Refresh();
            DataConfig clsdt = new DataConfig();

            DataTable _mdata = clsdt.getTable("select   [Keiro_id]　,[Arrival]  N'出発地'   ,[Departure]   N'到着地'  ,[Transportation]  N'交通手段'   ,[Fare] N'値段' from [dbo].[KEIRO]"); 
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.DataSource = _mdata;
            gridControl1.Refresh();

            gridView1.Columns["値段"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gridView1.Columns["値段"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["値段"].DisplayFormat.FormatString = "#,##0";
            gridView1.Columns[0].Visible = false;
            gridView1.BestFitColumns();
        }
        private void disablecontrol(bool t)
        {

            foreach (Control c in groupControl2.Controls)
            {

                c.Enabled = t;

            }
            txtID.Enabled = false;
        }

        private void frmKeiro_Load(object sender, EventArgs e)
        {

            disablecontrol(false);
            btnSave.Enabled = false;
            btnDel.Enabled = false;
            GENKEIRO();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                {
                    int slrow = gridView1.GetSelectedRows()[i];
                    IDGD = int.Parse(gridView1.GetRowCellValue(slrow, gridView1.Columns["Keiro_id"]).ToString());
                    DataConfig clsget = new DataConfig();
                    DataTable _mdt = clsget.getTable("select * from [KEIRO] where Keiro_id='" + IDGD.ToString() + "'");
                    if (_mdt != null && _mdt.Rows.Count > 0)
                    {

                        txtID.Text = _mdt.Rows[0]["Keiro_id"].ToString();
                        txtArival.Text = _mdt.Rows[0]["Arrival"].ToString();
                        txtDeparture.Text = _mdt.Rows[0]["Departure"].ToString();
                        txttransport.Text = _mdt.Rows[0]["transportation"].ToString();

                        try
                        {
                            txtFare.Text = decimal.Parse(_mdt.Rows[0]["fare"].ToString()).ToString("#,##0");
                        }
                        catch { txtFare.Text = "0"; }
                       
                        btnDel.Enabled = true;
                        btnSave.Enabled = true;
                        IsNew = 0; isUpdate = 1;
                        disablecontrol(true);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupControl2.Controls)
            {
                if (c.GetType() == typeof(TextBox) && c.Text == "" )
                {
                    if (c.Name.IndexOf("txtID") == -1)
                    {
                        MessageBox.Show("すべての情報を入力してください");
                        c.Focus();
                        return;
                    }
                }
            }
            string StoreName = "", strconfirm = "";
            if (IsNew == 1)
            {
                StoreName = "SP_INSERT_KEIRO";
                strconfirm = "追加してよろしいでしょうか?";
                DataConfig CLSCHECK = new DataConfig();
                if (CLSCHECK.getTable("select * from KEIRO where Arrival=N'" + txtArival.Text + "' and Departure=N'" + txtDeparture.Text + "' and Transportation=N'" + txttransport.Text + "'").Rows.Count > 0)
                {
                    MessageBox.Show("入力した内容が重複しています。");
                    return;
                }
            }
            else if (isUpdate == 1)
            {
                StoreName = "SP_UPDATE_KEIRO";
                strconfirm = "更新してよろしいでしょうか?";
            }
            //    #region
            DialogResult result = MessageBox.Show(strconfirm, "確認", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                DataConfig clins = new DataConfig();
                string SQL = "exec " + StoreName + " " + IDGD.ToString() + ",N'" + txtArival.Text.ToString() + "',N'" + txtDeparture.Text + "',N'" + txttransport.Text + "'," + decimal.Parse(txtFare.Text).ToString() ;
                clins.Excute(SQL);

                Clear();
                btnSave.Enabled = false;
                btnDel.Enabled = false;
                GENKEIRO();
                IDGD = 0;
                MessageBox.Show("追加しました。");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("削除してもよろしいですか?", "確認", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DataConfig clins = new DataConfig();
                string SQL = "exec SP_DELETE_KEIRO " + IDGD.ToString();
                clins.Excute(SQL);

                Clear();
                btnSave.Enabled = false;
                btnDel.Enabled = false;
                GENKEIRO();
                IDGD = 0;
                MessageBox.Show("削除しました。");
            }
        }

        private void ToolStripDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                {
                    int slrow = gridView1.GetSelectedRows()[i];
                    IDGD = int.Parse(gridView1.GetRowCellValue(slrow, gridView1.Columns["Keiro_id"]).ToString());
                    DataConfig clsget = new DataConfig();
                    DataTable _mdt = clsget.getTable("select * from [KEIRO] where Keiro_id='" + IDGD.ToString() + "'");
                    if (_mdt != null && _mdt.Rows.Count > 0)
                    {

                        DialogResult result = MessageBox.Show("削除してもよろしいですか?", "確認", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            DataConfig clins = new DataConfig();
                            string SQL = "exec SP_DELETE_KEIRO " + IDGD.ToString();
                            clins.Excute(SQL);

                            Clear();
                            btnSave.Enabled = false;
                            btnDel.Enabled = false;
                            GENKEIRO();
                            IDGD = 0;
                            MessageBox.Show("削除しました。");
                        }
                    }
                }
            }
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            detailViewContextMenuStrip.Show(MousePosition);
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

        private void txtFare_Enter(object sender, EventArgs e)
        {

            txtFare.SelectAll();
            txtFare.Focus();
        }

        private void txtFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 13)
            {
                e.Handled = true;
            }
           
        }

        private void txtFare_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFare.Text))
            {
                try
                {
                    txtFare.Text = decimal.Parse(txtFare.Text).ToString("#,##0");


                }
                catch
                {
                    txtFare.Text = "0";
                }
            }
        }

        private void txtArival_Enter(object sender, EventArgs e)
        {
            txtArival.SelectAll();
            txtArival.Focus();
        }

        private void txtDeparture_Enter(object sender, EventArgs e)
        {
            txtDeparture.SelectAll();
            txtDeparture.Focus();
        }

        private void txttransport_Enter(object sender, EventArgs e)
        {
            txttransport.SelectAll();
            txttransport.Focus();
        }
       
    }
}
