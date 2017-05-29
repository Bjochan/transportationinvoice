using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TransportationInvoice.Properties;
using TransportationInvoice.LogicClasses;
namespace TransportationInvoice
{
    public partial class Login : Form
    {
        
        clsLogin objlogin = new clsLogin();
        string strServerIP = Login_Settings.Default.strServerIP;
        string ip = "";
        //string server_update;     
       // Thread th;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {            
            Get_IDPass();           
        }

        private void save_IDPass(string ID)
        {
            Login_Settings.Default.strID =objlogin.EncryptString(ID);
            Login_Settings.Default.Save();
        }
       
        private void Get_IDPass()
        {
            string str=Login_Settings.Default.strID;
            if (str!="")
               txtEmployeeid.Text = objlogin.DecryptString(str);

            lbVer.Text += Login_Settings.Default.strVersion;
            lblStatus.Text = "";
            setColor(1);
            this.Refresh();
            Set_Focus();
        }
        private void Set_Focus()
        {
            if (txtEmployeeid.Text == "") txtEmployeeid.Focus();
            else txtPass.Focus();
        }
        
        //サーバ接続確認    
        private bool checkconnect( string ipserver)
        .W{
            try
            {
                System.Net.Sockets.TcpClient clnt = new System.Net.Sockets.TcpClient(ipserver, 80);
                clnt.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void Runconnect()
        {
            try
            {
                if (checkconnect(strServerIP))
                {
                    ip = strServerIP;
                }              
                else MessageBox.Show("サーバーと接続できません。ネットワークを再確認または終了して再起動してください。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            btnLogin.Text = "ログイン";
            btnLogin.ForeColor = Color.Black;
            btnLogin.Font = new Font(btnLogin.Font, FontStyle.Regular);
            
        }


//「ログイン」ボタン押下イベント
private void btnLogin_Click(object sender, EventArgs e)
{

    this.Cursor = Cursors.WaitCursor;
    string ID = txtEmployeeid.Text;
    string Pass = txtPass.Text;
    if (ID != "" & Pass != "")
    {
        btnLogin.Text = "ローディング...";
        btnLogin.ForeColor = Color.Red;
        btnLogin.Font = new Font(btnLogin.Font, FontStyle.Bold);
        btnLogin.Refresh();
        // Runconnect();             

        bool bCheck = false;

        try
        {
            User obj = new User();
            DataTable ds = obj.GetInfoUser(ID, Pass);

            if (ds.Rows.Count > 0 && ds.Rows[0]["Employee_LoginID"].ToString() == ID && ds.Rows[0]["Employee_Pass"].ToString() == Pass)
            {
                bCheck = true;
                GlobalVariables.User = ds.Rows[0]["Employee_LoginID"].ToString();
                GlobalVariables.userName = ds.Rows[0]["Employee_name"].ToString();
                GlobalVariables.IsAdmin = int.Parse(ds.Rows[0]["isadmin"].ToString());

                GlobalVariables.ApplicationName = ds.Rows[0]["Appname"].ToString();
                GlobalVariables.Version = ds.Rows[0]["version"].ToString();
            }
            else
            {
                bCheck = false;
            }
            if (bCheck == true)
            {

                save_IDPass(ID);
                this.Hide();
                // メインフォームを表示する
                frmMain f = new frmMain();
                f.Show();
            }

            //　IDとかパスワードが正しくない場合
            else
            {
                this.Cursor = Cursors.Default;
                setColor(0);
                lblStatus.Text = "社員IDまたはパスワードが正しいありません。再入力してください。";
                Set_Focus();
            }
        }

        //サーバと接続できない場合
        catch (Exception ex)
        {
            this.Cursor = Cursors.Default;
            setColor(0);
            lblStatus.Text = "エラーが発生しています。ログインできません。";
            Set_Focus();

        }

    }

    //Idとかパスワードの未入力場合
    else
                if (ID == "")
                {
                    this.Cursor = Cursors.Default;
                    setColor(0);
                    lblStatus.Text = "社員IDを入力してください。";
                    txtEmployeeid.Focus();
                }
                else
                    if (Pass == "")
                    {
                        this.Cursor = Cursors.Default;
                        setColor(0);
                        lblStatus.Text = "パスワードを入力してください。";
                        txtPass.Focus();
                    }
               
                       
        }
      
       
        private void setColor(int type)
        {
            switch (type)
            { 
                case 0:
                    lblStatus.ForeColor = Color.FromArgb(250,60,5);
                    break;
                case 1:
                    lblStatus.ForeColor = Color.White;
                    break;
                case 2:
                    lblStatus.ForeColor = Color.FromArgb(3,173, 3);
                    break;
                default:              
                    lblStatus.ForeColor = Color.White;
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
             

        private void txtEmployeeid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtEmployeeid.Text.Trim()!="") txtPass.Focus();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPass.Text.Trim() != "")
            {
                btnLogin_Click(sender, e);
            }
        }

        //「登録」ボタン押下イベント
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegis f = new frmRegis();
            f.ShowDialog();
        }
       
    }
}
