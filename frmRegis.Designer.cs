namespace TransportationInvoice
{
    partial class frmRegis
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPas = new System.Windows.Forms.Label();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.cmbBumon = new System.Windows.Forms.ComboBox();
            this.lblBu = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "氏名:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 19);
            this.txtName.TabIndex = 1;
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(132, 103);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(232, 19);
            this.txtLoginID.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(56, 106);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 12);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "社員ID:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(132, 148);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(232, 19);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPas
            // 
            this.lblPas.AutoSize = true;
            this.lblPas.Location = new System.Drawing.Point(44, 151);
            this.lblPas.Name = "lblPas";
            this.lblPas.Size = new System.Drawing.Size(54, 12);
            this.lblPas.TabIndex = 4;
            this.lblPas.Text = "パスワード:";
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(132, 247);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(232, 19);
            this.txtSiteName.TabIndex = 7;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(49, 250);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(46, 12);
            this.lblSite.TabIndex = 6;
            this.lblSite.Text = "サイト名:";
            // 
            // cmbBumon
            // 
            this.cmbBumon.FormattingEnabled = true;
            this.cmbBumon.Location = new System.Drawing.Point(132, 197);
            this.cmbBumon.Name = "cmbBumon";
            this.cmbBumon.Size = new System.Drawing.Size(232, 20);
            this.cmbBumon.TabIndex = 85;
            // 
            // lblBu
            // 
            this.lblBu.AutoSize = true;
            this.lblBu.Location = new System.Drawing.Point(64, 200);
            this.lblBu.Name = "lblBu";
            this.lblBu.Size = new System.Drawing.Size(31, 12);
            this.lblBu.TabIndex = 84;
            this.lblBu.Text = "部門:";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(132, 294);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 21);
            this.btnReg.TabIndex = 86;
            this.btnReg.Text = "登録";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(240, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 87;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInf
            // 
            this.lblInf.AutoSize = true;
            this.lblInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInf.Location = new System.Drawing.Point(154, 330);
            this.lblInf.Name = "lblInf";
            this.lblInf.Size = new System.Drawing.Size(0, 20);
            this.lblInf.TabIndex = 88;
            // 
            // frmRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 351);
            this.Controls.Add(this.lblInf);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.cmbBumon);
            this.Controls.Add(this.lblBu);
            this.Controls.Add(this.txtSiteName);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPas);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登録フォーム";
            this.Load += new System.EventHandler(this.frmRegis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPas;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.ComboBox cmbBumon;
        private System.Windows.Forms.Label lblBu;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInf;
    }
}