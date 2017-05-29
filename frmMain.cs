using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TransportationInvoice.Forms;
using TransportationInvoice.LogicClasses;
namespace TransportationInvoice
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
          //  this.splitContainerControl1.SplitterPosition = 30;
           // this.splitContainerControl2.SplitterPosition =this.splitContainerControl2.Height- 30;
        }
        private void Main_Load(object sender, EventArgs e)
        {

            try
            {
                this.Text = GlobalVariables.ApplicationName;
                ShowFrom(new frmKoguchi());
            }
            catch
            {
            }
            //   ShowForm(new frmCustInfomation());
        }
        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
        }


        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ShowFrom(new frmUser());
        }
        public void ShowFrom(Form childForm)
        {
            for (int i = 0; i < splitContainerControl2.Panel1.Controls.Count; i++)
            {
                if (splitContainerControl2.Panel1.Controls[i].Name == childForm.Name)
                {
                    splitContainerControl2.Panel1.Controls[i].Focus();
                    splitContainerControl2.Panel1.Controls[i].BringToFront();
                    return;
                }
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            childForm.Dock = DockStyle.Fill;
            childForm.MaximizeBox = true;
            childForm.WindowState = FormWindowState.Normal;
            childForm.ResumeLayout(true);
            childForm.Width = splitContainerControl1.Panel1.Width;
            childForm.Height = splitContainerControl1.Panel1.Height;
            childForm.Location = splitContainerControl1.Panel1.Location;
            childForm.Show();
            splitContainerControl2.Panel1.Controls.Add(childForm);
            splitContainerControl2.Panel1.Controls[childForm.Name].BringToFront();
        }

      
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void _About_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }

      
      
        private void _close_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void _frmChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass f = new frmChangePass();
            f.ShowDialog();
        }

        private void _LKoguchi_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmKoguchi());
        }

        private void keiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmKeiro());
        }

        private void list_KH_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmCustomers());
        }

        private void dm_DA_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmProjects());
        }

        private void _frmUsers_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmUsers());
        }

        private void bumonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmBumon());
        }
    }
}
