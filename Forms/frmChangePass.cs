using System;
using System.Data;
using System.Windows.Forms;
using TransportationInvoice.LogicClasses;
namespace TransportationInvoice.Forms
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txtUserName.Text = GlobalVariables.User;
            txtFullName.Text = GlobalVariables.userName;            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            if (txtPass_New.Text != txtConfirm_Pass.Text)
            {
                lblStatus.Text = "入力内容は一致しません。再入力してください";
            }
            else if (txtPass_old.Text == txtPass_New.Text)
            {
                lblStatus.Text = "重複しました。再入力してください";
            }
            else
            {
                User cls = new User();
                DataTable _mdata = cls.ChangePass(GlobalVariables.User, txtPass_old.Text, txtPass_New.Text);
                if (_mdata != null && _mdata.Rows.Count > 0)
                {
                    lblStatus.Text = _mdata.Rows[0][0].ToString() + " " + _mdata.Rows[0][1].ToString();
                }
            }
        }
    }
}
