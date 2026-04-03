namespace WindowsFormsApp1
{
    partial class Form1
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
            this.grp = new System.Windows.Forms.GroupBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.lblService = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.chkSysdba = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnUseConfig = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // grp
            // 
            this.grp.Controls.Add(this.lblHost);
            this.grp.Controls.Add(this.txtHost);
            this.grp.Controls.Add(this.lblPort);
            this.grp.Controls.Add(this.numPort);
            this.grp.Controls.Add(this.lblService);
            this.grp.Controls.Add(this.txtService);
            this.grp.Controls.Add(this.lblUser);
            this.grp.Controls.Add(this.txtUser);
            this.grp.Controls.Add(this.lblPass);
            this.grp.Controls.Add(this.txtPass);
            this.grp.Controls.Add(this.chkSysdba);
            this.grp.Controls.Add(this.btnTest);
            this.grp.Controls.Add(this.btnUseConfig);
            this.grp.Location = new System.Drawing.Point(12, 12);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(776, 165);
            this.grp.TabIndex = 0;
            this.grp.TabStop = false;
            this.grp.Text = "Kết nối Oracle";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(16, 32);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(90, 29);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(200, 20);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "localhost";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(320, 32);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(380, 29);
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
            this.numPort.Size = new System.Drawing.Size(120, 20);
            this.numPort.TabIndex = 3;
            this.numPort.Value = new decimal(new int[] {
            1521,
            0,
            0,
            0});
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(16, 66);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(68, 13);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service/PDB:";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(90, 63);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(200, 20);
            this.txtService.TabIndex = 5;
            this.txtService.Text = "XEPDB1";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(320, 66);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(380, 63);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 20);
            this.txtUser.TabIndex = 7;
            this.txtUser.Text = "system";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(16, 100);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(90, 97);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 20);
            this.txtPass.TabIndex = 9;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // chkSysdba
            // 
            this.chkSysdba.AutoSize = true;
            this.chkSysdba.Location = new System.Drawing.Point(323, 99);
            this.chkSysdba.Name = "chkSysdba";
            this.chkSysdba.Size = new System.Drawing.Size(128, 17);
            this.chkSysdba.TabIndex = 10;
            this.chkSysdba.Text = "Đăng nhập SYSDBA";
            this.chkSysdba.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(613, 28);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(145, 23);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Kiểm tra kết nối (nhập tay)";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnUseConfig
            // 
            this.btnUseConfig.Location = new System.Drawing.Point(613, 62);
            this.btnUseConfig.Name = "btnUseConfig";
            this.btnUseConfig.Size = new System.Drawing.Size(145, 23);
            this.btnUseConfig.TabIndex = 12;
            this.btnUseConfig.Text = "Kiểm tra từ App.config";
            this.btnUseConfig.UseVisualStyleBackColor = true;
            this.btnUseConfig.Click += new System.EventHandler(this.btnUseConfig_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 193);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(776, 245);
            this.txtResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.grp);
            this.Name = "Form1";
            this.Text = "NHOM 09 - Kết nối";
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox chkSysdba;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnUseConfig;
        private System.Windows.Forms.TextBox txtResult;
    }
}

