namespace WindowsFormsApp1
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grp = new System.Windows.Forms.GroupBox();
            this.chkSysdba = new System.Windows.Forms.CheckBox();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // grp
            // 
            this.grp.Controls.Add(this.chkSysdba);
            this.grp.Controls.Add(this.txtPreview);
            this.grp.Controls.Add(this.lblPreview);
            this.grp.Controls.Add(this.txtPassword);
            this.grp.Controls.Add(this.lblPassword);
            this.grp.Controls.Add(this.txtUser);
            this.grp.Controls.Add(this.lblUser);
            this.grp.Controls.Add(this.txtService);
            this.grp.Controls.Add(this.lblService);
            this.grp.Controls.Add(this.numPort);
            this.grp.Controls.Add(this.lblPort);
            this.grp.Controls.Add(this.txtHost);
            this.grp.Controls.Add(this.lblHost);
            this.grp.Location = new System.Drawing.Point(12, 12);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(660, 212);
            this.grp.TabIndex = 0;
            this.grp.TabStop = false;
            this.grp.Text = "Thông tin đăng nhập";
            // 
            // chkSysdba
            // 
            this.chkSysdba.AutoSize = true;
            this.chkSysdba.Location = new System.Drawing.Point(96, 143);
            this.chkSysdba.Name = "chkSysdba";
            this.chkSysdba.Size = new System.Drawing.Size(128, 17);
            this.chkSysdba.TabIndex = 10;
            this.chkSysdba.Text = "Đăng nhập SYSDBA";
            this.chkSysdba.UseVisualStyleBackColor = true;
            this.chkSysdba.CheckedChanged += new System.EventHandler(this.chkSysdba_CheckedChanged);
            // 
            // txtPreview
            // 
            this.txtPreview.Location = new System.Drawing.Point(96, 171);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.Size = new System.Drawing.Size(548, 20);
            this.txtPreview.TabIndex = 12;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(15, 174);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(75, 13);
            this.lblPreview.TabIndex = 11;
            this.lblPreview.Text = "Chuỗi kết nối:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 113);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(96, 77);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(240, 20);
            this.txtUser.TabIndex = 7;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(15, 80);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Tài khoản:";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(96, 44);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(240, 20);
            this.txtService.TabIndex = 5;
            this.txtService.TextChanged += new System.EventHandler(this.txtService_TextChanged);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(15, 47);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(68, 13);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service/PDB:";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(456, 18);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(188, 20);
            this.numPort.TabIndex = 3;
            this.numPort.ValueChanged += new System.EventHandler(this.numPort_ValueChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(388, 20);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(96, 18);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(240, 20);
            this.txtHost.TabIndex = 1;
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(15, 21);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Máy chủ:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(472, 233);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 27);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(598, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.grp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHOM 09 - Đăng nhập";
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.CheckBox chkSysdba;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
    }
}

