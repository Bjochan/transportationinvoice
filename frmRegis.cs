using System;
using System.Data;
using System.Windows.Forms;
using TransportationInvoice.LogicClasses;

namespace TransportationInvoice
{
    public partial class frmRegis : Form
    {
        public frmRegis()
        {
            InitializeComponent();
        }

        //フォームロード
        private void frmRegis_Load(object sender, EventArgs e)
        {
            cmbBumon.Items.Clear();
            DataConfig clsdt = new DataConfig();
            DataTable _mbumon = clsdt.getTable("select * from BUMON");
            if (_mbumon != null)
            {
                for (int j = 0; j < _mbumon.Rows.Count; j++)
                {
                    cmbBumon.Items.Add(new GlobalVariables.Item(_mbumon.Rows[j]["Bumon_Name"].ToString().ToUpper(), _mbumon.Rows[j]["ID"].ToString().ToUpper()));

                }
                cmbBumon.SelectedIndex = 0;
            }
        }

        //キャンセルの場合
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //「登録」ボタンの押下
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("すべての情報を入力してください");
                txtName.Focus();
                return;
            }
            if (txtLoginID.Text == "")
            {
                MessageBox.Show("すべての情報を入力してください");
                txtLoginID.Focus();
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("すべての情報を入力してください");
                txtPass.Focus();
                return;
            }

            //DB確認
            string StoreName = "SP_INSERT_USERS";
            DialogResult result = MessageBox.Show("登録して欲しいですか。", "確認", MessageBoxButtons.YesNo);


            
            if (result == DialogResult.Yes)
            {

                DataTable _mchek = new DataConfig().getTable("select * from EMPLOYEE where Employee_LoginID='" + txtLoginID.Text + "'");
                if (_mchek != null && _mchek.Rows.Count > 0)
                {
                    MessageBox.Show("ユーザが存在しました。");
                    txtLoginID.Focus();
                    return;
                }
                else
                {
                    DataConfig clins = new DataConfig();

                    if (cmbBumon.SelectedIndex == -1)
                        cmbBumon.SelectedIndex = 0;
                    GlobalVariables.Item it = (GlobalVariables.Item)cmbBumon.SelectedItem;

                    string SQL = "exec " + StoreName + " 0,N'" + txtName.Text.ToString() + "',N'" + txtLoginID.Text + "',N'" + txtPass.Text + "',N'" + txtSiteName.Text + "'," + it.Value + ",0";
                    clins.Excute(SQL);
                    lblInf.Text = "登録に成功しました。";
                    btnReg.Enabled = false;
                }
            }
        }
    }
}
