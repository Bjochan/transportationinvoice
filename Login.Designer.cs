namespace TransportationInvoice
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtEmployeeid = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblApp = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.prDownload = new System.Windows.Forms.ProgressBar();
            this.lbVer = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmp
            // 
            resources.ApplyResources(this.lblEmp, "lblEmp");
            this.lblEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblEmp.Name = "lblEmp";
            // 
            // lblPass
            // 
            resources.ApplyResources(this.lblPass, "lblPass");
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Name = "lblPass";
            // 
            // txtEmployeeid
            // 
            resources.ApplyResources(this.txtEmployeeid, "txtEmployeeid");
            this.txtEmployeeid.Name = "txtEmployeeid";
            this.txtEmployeeid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeid_KeyDown);
            // 
            // txtPass
            // 
            resources.ApplyResources(this.txtPass, "txtPass");
            this.txtPass.Name = "txtPass";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // lblApp
            // 
            resources.ApplyResources(this.lblApp, "lblApp");
            this.lblApp.BackColor = System.Drawing.Color.Transparent;
            this.lblApp.Name = "lblApp";
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Name = "lblStatus";
            // 
            // prDownload
            // 
            resources.ApplyResources(this.prDownload, "prDownload");
            this.prDownload.Name = "prDownload";
            // 
            // lbVer
            // 
            resources.ApplyResources(this.lbVer, "lbVer");
            this.lbVer.BackColor = System.Drawing.Color.Transparent;
            this.lbVer.ForeColor = System.Drawing.Color.Black;
            this.lbVer.Name = "lbVer";
            // 
            // btnRegister
            // 
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TransportationInvoice.Properties.Resources.img_logo;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmployeeid);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.prDownload);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtEmployeeid;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar prDownload;
        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}