namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabConn = new System.Windows.Forms.TabPage();
            this.grpConn = new System.Windows.Forms.GroupBox();
            this.chkSysdba = new System.Windows.Forms.CheckBox();
            this.btnApplyConn = new System.Windows.Forms.Button();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.txtConnPreview = new System.Windows.Forms.TextBox();
            this.lblConnPreview = new System.Windows.Forms.Label();
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
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.grpUserActions = new System.Windows.Forms.GroupBox();
            this.btnUserUnlock = new System.Windows.Forms.Button();
            this.btnUserLock = new System.Windows.Forms.Button();
            this.btnUserDrop = new System.Windows.Forms.Button();
            this.btnUserAlterPass = new System.Windows.Forms.Button();
            this.btnUserCreate = new System.Windows.Forms.Button();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnUsersRefresh = new System.Windows.Forms.Button();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.gridRoles = new System.Windows.Forms.DataGridView();
            this.grpRoleActions = new System.Windows.Forms.GroupBox();
            this.btnRoleDrop = new System.Windows.Forms.Button();
            this.btnRoleCreate = new System.Windows.Forms.Button();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.btnRolesRefresh = new System.Windows.Forms.Button();
            this.tabGrant = new System.Windows.Forms.TabPage();
            this.gridPrivs = new System.Windows.Forms.DataGridView();
            this.grpGrant = new System.Windows.Forms.GroupBox();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.btnGrant = new System.Windows.Forms.Button();
            this.chkWithOption = new System.Windows.Forms.CheckBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.txtObjectName = new System.Windows.Forms.TextBox();
            this.lblObject = new System.Windows.Forms.Label();
            this.radGrantObjPriv = new System.Windows.Forms.RadioButton();
            this.radGrantSysPriv = new System.Windows.Forms.RadioButton();
            this.radGrantRole = new System.Windows.Forms.RadioButton();
            this.txtGrantWhat = new System.Windows.Forms.TextBox();
            this.lblGrantWhat = new System.Windows.Forms.Label();
            this.txtGrantee = new System.Windows.Forms.TextBox();
            this.lblGrantee = new System.Windows.Forms.Label();
            this.tabView = new System.Windows.Forms.TabPage();
            this.btnViewPrivs = new System.Windows.Forms.Button();
            this.cboViewKind = new System.Windows.Forms.ComboBox();
            this.lblViewKind = new System.Windows.Forms.Label();
            this.txtViewName = new System.Windows.Forms.TextBox();
            this.lblViewName = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.tabConn.SuspendLayout();
            this.grpConn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.grpUserActions.SuspendLayout();
            this.tabRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).BeginInit();
            this.grpRoleActions.SuspendLayout();
            this.tabGrant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrivs)).BeginInit();
            this.grpGrant.SuspendLayout();
            this.tabView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabConn);
            this.tabs.Controls.Add(this.tabUsers);
            this.tabs.Controls.Add(this.tabRoles);
            this.tabs.Controls.Add(this.tabGrant);
            this.tabs.Controls.Add(this.tabView);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1100, 700);
            this.tabs.TabIndex = 0;
            // 
            // tabConn
            // 
            this.tabConn.Controls.Add(this.grpConn);
            this.tabConn.Location = new System.Drawing.Point(4, 22);
            this.tabConn.Name = "tabConn";
            this.tabConn.Padding = new System.Windows.Forms.Padding(10);
            this.tabConn.Size = new System.Drawing.Size(1092, 674);
            this.tabConn.TabIndex = 0;
            this.tabConn.Text = "Kết nối";
            this.tabConn.UseVisualStyleBackColor = true;
            // 
            // grpConn
            // 
            this.grpConn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConn.Controls.Add(this.chkSysdba);
            this.grpConn.Controls.Add(this.btnApplyConn);
            this.grpConn.Controls.Add(this.btnTestConn);
            this.grpConn.Controls.Add(this.txtConnPreview);
            this.grpConn.Controls.Add(this.lblConnPreview);
            this.grpConn.Controls.Add(this.txtPassword);
            this.grpConn.Controls.Add(this.lblPassword);
            this.grpConn.Controls.Add(this.txtUser);
            this.grpConn.Controls.Add(this.lblUser);
            this.grpConn.Controls.Add(this.txtService);
            this.grpConn.Controls.Add(this.lblService);
            this.grpConn.Controls.Add(this.numPort);
            this.grpConn.Controls.Add(this.lblPort);
            this.grpConn.Controls.Add(this.txtHost);
            this.grpConn.Controls.Add(this.lblHost);
            this.grpConn.Location = new System.Drawing.Point(13, 13);
            this.grpConn.Name = "grpConn";
            this.grpConn.Size = new System.Drawing.Size(1066, 220);
            this.grpConn.TabIndex = 0;
            this.grpConn.TabStop = false;
            this.grpConn.Text = "Thông tin kết nối Oracle";
            // 
            // chkSysdba
            // 
            this.chkSysdba.AutoSize = true;
            this.chkSysdba.Location = new System.Drawing.Point(90, 151);
            this.chkSysdba.Name = "chkSysdba";
            this.chkSysdba.Size = new System.Drawing.Size(128, 17);
            this.chkSysdba.TabIndex = 10;
            this.chkSysdba.Text = "Đăng nhập SYSDBA";
            this.chkSysdba.UseVisualStyleBackColor = true;
            this.chkSysdba.CheckedChanged += new System.EventHandler(this.chkSysdba_CheckedChanged);
            // 
            // btnApplyConn
            // 
            this.btnApplyConn.Location = new System.Drawing.Point(718, 147);
            this.btnApplyConn.Name = "btnApplyConn";
            this.btnApplyConn.Size = new System.Drawing.Size(160, 23);
            this.btnApplyConn.TabIndex = 12;
            this.btnApplyConn.Text = "Áp dụng (dùng trong ứng dụng)";
            this.btnApplyConn.UseVisualStyleBackColor = true;
            this.btnApplyConn.Click += new System.EventHandler(this.btnApplyConn_Click);
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(552, 147);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(160, 23);
            this.btnTestConn.TabIndex = 11;
            this.btnTestConn.Text = "Kiểm tra kết nối";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // txtConnPreview
            // 
            this.txtConnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnPreview.Location = new System.Drawing.Point(90, 186);
            this.txtConnPreview.Name = "txtConnPreview";
            this.txtConnPreview.ReadOnly = true;
            this.txtConnPreview.Size = new System.Drawing.Size(958, 20);
            this.txtConnPreview.TabIndex = 14;
            // 
            // lblConnPreview
            // 
            this.lblConnPreview.AutoSize = true;
            this.lblConnPreview.Location = new System.Drawing.Point(16, 189);
            this.lblConnPreview.Name = "lblConnPreview";
            this.lblConnPreview.Size = new System.Drawing.Size(67, 13);
            this.lblConnPreview.TabIndex = 13;
            this.lblConnPreview.Text = "Chuỗi kết nối:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(90, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(90, 86);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(250, 20);
            this.txtUser.TabIndex = 7;
            this.txtUser.Text = "sys";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(16, 89);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Tài khoản:";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(90, 53);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(250, 20);
            this.txtService.TabIndex = 5;
            this.txtService.Text = "XEPDB1";
            this.txtService.TextChanged += new System.EventHandler(this.txtService_TextChanged);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(16, 56);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(68, 13);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service/PDB:";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(552, 20);
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
            this.numPort.Size = new System.Drawing.Size(160, 20);
            this.numPort.TabIndex = 3;
            this.numPort.Value = new decimal(new int[] {
            1521,
            0,
            0,
            0});
            this.numPort.ValueChanged += new System.EventHandler(this.numPort_ValueChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(494, 22);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(90, 20);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(250, 20);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "localhost";
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(16, 23);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Máy chủ:";
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.gridUsers);
            this.tabUsers.Controls.Add(this.grpUserActions);
            this.tabUsers.Controls.Add(this.btnUsersRefresh);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(10);
            this.tabUsers.Size = new System.Drawing.Size(1092, 674);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Người dùng";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // gridUsers
            // 
            this.gridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Location = new System.Drawing.Point(13, 152);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.Size = new System.Drawing.Size(1066, 509);
            this.gridUsers.TabIndex = 2;
            // 
            // grpUserActions
            // 
            this.grpUserActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUserActions.Controls.Add(this.btnUserUnlock);
            this.grpUserActions.Controls.Add(this.btnUserLock);
            this.grpUserActions.Controls.Add(this.btnUserDrop);
            this.grpUserActions.Controls.Add(this.btnUserAlterPass);
            this.grpUserActions.Controls.Add(this.btnUserCreate);
            this.grpUserActions.Controls.Add(this.txtUserPass);
            this.grpUserActions.Controls.Add(this.lblUserPass);
            this.grpUserActions.Controls.Add(this.txtUserName);
            this.grpUserActions.Controls.Add(this.lblUserName);
            this.grpUserActions.Location = new System.Drawing.Point(13, 42);
            this.grpUserActions.Name = "grpUserActions";
            this.grpUserActions.Size = new System.Drawing.Size(1066, 104);
            this.grpUserActions.TabIndex = 1;
            this.grpUserActions.TabStop = false;
            this.grpUserActions.Text = "Thao tác User";
            // 
            // btnUserUnlock
            // 
            this.btnUserUnlock.Location = new System.Drawing.Point(858, 62);
            this.btnUserUnlock.Name = "btnUserUnlock";
            this.btnUserUnlock.Size = new System.Drawing.Size(190, 23);
            this.btnUserUnlock.TabIndex = 8;
            this.btnUserUnlock.Text = "Mở khóa";
            this.btnUserUnlock.UseVisualStyleBackColor = true;
            this.btnUserUnlock.Click += new System.EventHandler(this.btnUserUnlock_Click);
            // 
            // btnUserLock
            // 
            this.btnUserLock.Location = new System.Drawing.Point(662, 62);
            this.btnUserLock.Name = "btnUserLock";
            this.btnUserLock.Size = new System.Drawing.Size(190, 23);
            this.btnUserLock.TabIndex = 7;
            this.btnUserLock.Text = "Khóa";
            this.btnUserLock.UseVisualStyleBackColor = true;
            this.btnUserLock.Click += new System.EventHandler(this.btnUserLock_Click);
            // 
            // btnUserDrop
            // 
            this.btnUserDrop.Location = new System.Drawing.Point(466, 62);
            this.btnUserDrop.Name = "btnUserDrop";
            this.btnUserDrop.Size = new System.Drawing.Size(190, 23);
            this.btnUserDrop.TabIndex = 6;
            this.btnUserDrop.Text = "Xóa (DROP ... CASCADE)";
            this.btnUserDrop.UseVisualStyleBackColor = true;
            this.btnUserDrop.Click += new System.EventHandler(this.btnUserDrop_Click);
            // 
            // btnUserAlterPass
            // 
            this.btnUserAlterPass.Location = new System.Drawing.Point(270, 62);
            this.btnUserAlterPass.Name = "btnUserAlterPass";
            this.btnUserAlterPass.Size = new System.Drawing.Size(190, 23);
            this.btnUserAlterPass.TabIndex = 5;
            this.btnUserAlterPass.Text = "Đổi mật khẩu";
            this.btnUserAlterPass.UseVisualStyleBackColor = true;
            this.btnUserAlterPass.Click += new System.EventHandler(this.btnUserAlterPass_Click);
            // 
            // btnUserCreate
            // 
            this.btnUserCreate.Location = new System.Drawing.Point(74, 62);
            this.btnUserCreate.Name = "btnUserCreate";
            this.btnUserCreate.Size = new System.Drawing.Size(190, 23);
            this.btnUserCreate.TabIndex = 4;
            this.btnUserCreate.Text = "Tạo (CREATE USER)";
            this.btnUserCreate.UseVisualStyleBackColor = true;
            this.btnUserCreate.Click += new System.EventHandler(this.btnUserCreate_Click);
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(310, 26);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(250, 20);
            this.txtUserPass.TabIndex = 3;
            this.txtUserPass.UseSystemPasswordChar = true;
            // 
            // lblUserPass
            // 
            this.lblUserPass.AutoSize = true;
            this.lblUserPass.Location = new System.Drawing.Point(250, 29);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(56, 13);
            this.lblUserPass.TabIndex = 2;
            this.lblUserPass.Text = "Mật khẩu:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(74, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(160, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(18, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(32, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tài khoản:";
            // 
            // btnUsersRefresh
            // 
            this.btnUsersRefresh.Location = new System.Drawing.Point(13, 13);
            this.btnUsersRefresh.Name = "btnUsersRefresh";
            this.btnUsersRefresh.Size = new System.Drawing.Size(140, 23);
            this.btnUsersRefresh.TabIndex = 0;
            this.btnUsersRefresh.Text = "Tải danh sách người dùng";
            this.btnUsersRefresh.UseVisualStyleBackColor = true;
            this.btnUsersRefresh.Click += new System.EventHandler(this.btnUsersRefresh_Click);
            // 
            // tabRoles
            // 
            this.tabRoles.Controls.Add(this.gridRoles);
            this.tabRoles.Controls.Add(this.grpRoleActions);
            this.tabRoles.Controls.Add(this.btnRolesRefresh);
            this.tabRoles.Location = new System.Drawing.Point(4, 22);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Padding = new System.Windows.Forms.Padding(10);
            this.tabRoles.Size = new System.Drawing.Size(1092, 674);
            this.tabRoles.TabIndex = 2;
            this.tabRoles.Text = "Vai trò";
            this.tabRoles.UseVisualStyleBackColor = true;
            // 
            // gridRoles
            // 
            this.gridRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRoles.Location = new System.Drawing.Point(13, 128);
            this.gridRoles.Name = "gridRoles";
            this.gridRoles.Size = new System.Drawing.Size(1066, 533);
            this.gridRoles.TabIndex = 2;
            // 
            // grpRoleActions
            // 
            this.grpRoleActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRoleActions.Controls.Add(this.btnRoleDrop);
            this.grpRoleActions.Controls.Add(this.btnRoleCreate);
            this.grpRoleActions.Controls.Add(this.txtRoleName);
            this.grpRoleActions.Controls.Add(this.lblRoleName);
            this.grpRoleActions.Location = new System.Drawing.Point(13, 42);
            this.grpRoleActions.Name = "grpRoleActions";
            this.grpRoleActions.Size = new System.Drawing.Size(1066, 80);
            this.grpRoleActions.TabIndex = 1;
            this.grpRoleActions.TabStop = false;
            this.grpRoleActions.Text = "Thao tác Role";
            // 
            // btnRoleDrop
            // 
            this.btnRoleDrop.Location = new System.Drawing.Point(506, 44);
            this.btnRoleDrop.Name = "btnRoleDrop";
            this.btnRoleDrop.Size = new System.Drawing.Size(200, 23);
            this.btnRoleDrop.TabIndex = 3;
            this.btnRoleDrop.Text = "Xóa (DROP ROLE)";
            this.btnRoleDrop.UseVisualStyleBackColor = true;
            this.btnRoleDrop.Click += new System.EventHandler(this.btnRoleDrop_Click);
            // 
            // btnRoleCreate
            // 
            this.btnRoleCreate.Location = new System.Drawing.Point(300, 44);
            this.btnRoleCreate.Name = "btnRoleCreate";
            this.btnRoleCreate.Size = new System.Drawing.Size(200, 23);
            this.btnRoleCreate.TabIndex = 2;
            this.btnRoleCreate.Text = "Tạo (CREATE ROLE)";
            this.btnRoleCreate.UseVisualStyleBackColor = true;
            this.btnRoleCreate.Click += new System.EventHandler(this.btnRoleCreate_Click);
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(74, 28);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(220, 20);
            this.txtRoleName.TabIndex = 1;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(18, 31);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(32, 13);
            this.lblRoleName.TabIndex = 0;
            this.lblRoleName.Text = "Tên vai trò:";
            // 
            // btnRolesRefresh
            // 
            this.btnRolesRefresh.Location = new System.Drawing.Point(13, 13);
            this.btnRolesRefresh.Name = "btnRolesRefresh";
            this.btnRolesRefresh.Size = new System.Drawing.Size(140, 23);
            this.btnRolesRefresh.TabIndex = 0;
            this.btnRolesRefresh.Text = "Tải danh sách vai trò";
            this.btnRolesRefresh.UseVisualStyleBackColor = true;
            this.btnRolesRefresh.Click += new System.EventHandler(this.btnRolesRefresh_Click);
            // 
            // tabGrant
            // 
            this.tabGrant.Controls.Add(this.grpGrant);
            this.tabGrant.Location = new System.Drawing.Point(4, 22);
            this.tabGrant.Name = "tabGrant";
            this.tabGrant.Padding = new System.Windows.Forms.Padding(10);
            this.tabGrant.Size = new System.Drawing.Size(1092, 674);
            this.tabGrant.TabIndex = 3;
            this.tabGrant.Text = "Cấp / Thu hồi quyền";
            this.tabGrant.UseVisualStyleBackColor = true;
            // 
            // gridPrivs
            // 
            this.gridPrivs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrivs.Location = new System.Drawing.Point(13, 114);
            this.gridPrivs.Name = "gridPrivs";
            this.gridPrivs.Size = new System.Drawing.Size(1066, 547);
            this.gridPrivs.TabIndex = 1;
            // 
            // grpGrant
            // 
            this.grpGrant.Controls.Add(this.btnRevoke);
            this.grpGrant.Controls.Add(this.btnGrant);
            this.grpGrant.Controls.Add(this.chkWithOption);
            this.grpGrant.Controls.Add(this.txtColumns);
            this.grpGrant.Controls.Add(this.lblColumns);
            this.grpGrant.Controls.Add(this.txtObjectName);
            this.grpGrant.Controls.Add(this.lblObject);
            this.grpGrant.Controls.Add(this.radGrantObjPriv);
            this.grpGrant.Controls.Add(this.radGrantSysPriv);
            this.grpGrant.Controls.Add(this.radGrantRole);
            this.grpGrant.Controls.Add(this.txtGrantWhat);
            this.grpGrant.Controls.Add(this.lblGrantWhat);
            this.grpGrant.Controls.Add(this.txtGrantee);
            this.grpGrant.Controls.Add(this.lblGrantee);
            this.grpGrant.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGrant.Location = new System.Drawing.Point(10, 10);
            this.grpGrant.Name = "grpGrant";
            this.grpGrant.Size = new System.Drawing.Size(1072, 120);
            this.grpGrant.TabIndex = 0;
            this.grpGrant.TabStop = false;
            this.grpGrant.Text = "Cấp quyền / Thu hồi quyền";
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(932, 80);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(120, 23);
            this.btnRevoke.TabIndex = 13;
            this.btnRevoke.Text = "Thu hồi (REVOKE)";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // btnGrant
            // 
            this.btnGrant.Location = new System.Drawing.Point(806, 80);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(120, 23);
            this.btnGrant.TabIndex = 12;
            this.btnGrant.Text = "Cấp quyền (GRANT)";
            this.btnGrant.UseVisualStyleBackColor = true;
            this.btnGrant.Click += new System.EventHandler(this.btnGrant_Click);
            // 
            // chkWithOption
            // 
            this.chkWithOption.AutoSize = true;
            this.chkWithOption.Location = new System.Drawing.Point(806, 31);
            this.chkWithOption.Name = "chkWithOption";
            this.chkWithOption.Size = new System.Drawing.Size(120, 17);
            this.chkWithOption.TabIndex = 11;
            this.chkWithOption.Text = "WITH GRANT / ADMIN OPTION";
            this.chkWithOption.UseVisualStyleBackColor = true;
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(544, 80);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(250, 20);
            this.txtColumns.TabIndex = 10;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(494, 83);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(44, 13);
            this.lblColumns.TabIndex = 9;
            this.lblColumns.Text = "Cột:";
            // 
            // txtObjectName
            // 
            this.txtObjectName.Location = new System.Drawing.Point(74, 80);
            this.txtObjectName.Name = "txtObjectName";
            this.txtObjectName.Size = new System.Drawing.Size(410, 20);
            this.txtObjectName.TabIndex = 8;
            this.txtObjectName.Text = "HR.EMPLOYEES";
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(18, 83);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(41, 13);
            this.lblObject.TabIndex = 7;
            this.lblObject.Text = "Đối tượng:";
            // 
            // radGrantObjPriv
            // 
            this.radGrantObjPriv.AutoSize = true;
            this.radGrantObjPriv.Location = new System.Drawing.Point(694, 29);
            this.radGrantObjPriv.Name = "radGrantObjPriv";
            this.radGrantObjPriv.Size = new System.Drawing.Size(73, 17);
            this.radGrantObjPriv.TabIndex = 6;
            this.radGrantObjPriv.Text = "Quyền đối tượng";
            this.radGrantObjPriv.UseVisualStyleBackColor = true;
            // 
            // radGrantSysPriv
            // 
            this.radGrantSysPriv.AutoSize = true;
            this.radGrantSysPriv.Location = new System.Drawing.Point(612, 29);
            this.radGrantSysPriv.Name = "radGrantSysPriv";
            this.radGrantSysPriv.Size = new System.Drawing.Size(58, 17);
            this.radGrantSysPriv.TabIndex = 5;
            this.radGrantSysPriv.Text = "Quyền hệ thống";
            this.radGrantSysPriv.UseVisualStyleBackColor = true;
            // 
            // radGrantRole
            // 
            this.radGrantRole.AutoSize = true;
            this.radGrantRole.Checked = true;
            this.radGrantRole.Location = new System.Drawing.Point(544, 29);
            this.radGrantRole.Name = "radGrantRole";
            this.radGrantRole.Size = new System.Drawing.Size(47, 17);
            this.radGrantRole.TabIndex = 4;
            this.radGrantRole.TabStop = true;
            this.radGrantRole.Text = "Vai trò";
            this.radGrantRole.UseVisualStyleBackColor = true;
            // 
            // txtGrantWhat
            // 
            this.txtGrantWhat.Location = new System.Drawing.Point(310, 28);
            this.txtGrantWhat.Name = "txtGrantWhat";
            this.txtGrantWhat.Size = new System.Drawing.Size(220, 20);
            this.txtGrantWhat.TabIndex = 3;
            this.txtGrantWhat.Text = "CONNECT";
            // 
            // lblGrantWhat
            // 
            this.lblGrantWhat.AutoSize = true;
            this.lblGrantWhat.Location = new System.Drawing.Point(250, 31);
            this.lblGrantWhat.Name = "lblGrantWhat";
            this.lblGrantWhat.Size = new System.Drawing.Size(34, 13);
            this.lblGrantWhat.TabIndex = 2;
            this.lblGrantWhat.Text = "Quyền / vai trò:";
            // 
            // txtGrantee
            // 
            this.txtGrantee.Location = new System.Drawing.Point(74, 28);
            this.txtGrantee.Name = "txtGrantee";
            this.txtGrantee.Size = new System.Drawing.Size(160, 20);
            this.txtGrantee.TabIndex = 1;
            // 
            // lblGrantee
            // 
            this.lblGrantee.AutoSize = true;
            this.lblGrantee.Location = new System.Drawing.Point(18, 31);
            this.lblGrantee.Name = "lblGrantee";
            this.lblGrantee.Size = new System.Drawing.Size(45, 13);
            this.lblGrantee.TabIndex = 0;
            this.lblGrantee.Text = "Người nhận:";
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.gridPrivs);
            this.tabView.Controls.Add(this.btnViewPrivs);
            this.tabView.Controls.Add(this.cboViewKind);
            this.tabView.Controls.Add(this.lblViewKind);
            this.tabView.Controls.Add(this.txtViewName);
            this.tabView.Controls.Add(this.lblViewName);
            this.tabView.Location = new System.Drawing.Point(4, 22);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(10);
            this.tabView.Size = new System.Drawing.Size(1092, 674);
            this.tabView.TabIndex = 4;
            this.tabView.Text = "Xem quyền";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // btnViewPrivs
            // 
            this.btnViewPrivs.Location = new System.Drawing.Point(544, 15);
            this.btnViewPrivs.Name = "btnViewPrivs";
            this.btnViewPrivs.Size = new System.Drawing.Size(120, 23);
            this.btnViewPrivs.TabIndex = 5;
            this.btnViewPrivs.Text = "Xem quyền";
            this.btnViewPrivs.UseVisualStyleBackColor = true;
            this.btnViewPrivs.Click += new System.EventHandler(this.btnViewPrivs_Click);
            // 
            // cboViewKind
            // 
            this.cboViewKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViewKind.FormattingEnabled = true;
            this.cboViewKind.Items.AddRange(new object[] {
            "USER",
            "ROLE"});
            this.cboViewKind.Location = new System.Drawing.Point(360, 17);
            this.cboViewKind.Name = "cboViewKind";
            this.cboViewKind.Size = new System.Drawing.Size(160, 21);
            this.cboViewKind.TabIndex = 3;
            // 
            // lblViewKind
            // 
            this.lblViewKind.AutoSize = true;
            this.lblViewKind.Location = new System.Drawing.Point(270, 20);
            this.lblViewKind.Name = "lblViewKind";
            this.lblViewKind.Size = new System.Drawing.Size(70, 13);
            this.lblViewKind.TabIndex = 2;
            this.lblViewKind.Text = "Loại đối tượng:";
            // 
            // txtViewName
            // 
            this.txtViewName.Location = new System.Drawing.Point(74, 17);
            this.txtViewName.Name = "txtViewName";
            this.txtViewName.Size = new System.Drawing.Size(180, 20);
            this.txtViewName.TabIndex = 1;
            // 
            // lblViewName
            // 
            this.lblViewName.AutoSize = true;
            this.lblViewName.Location = new System.Drawing.Point(10, 20);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(58, 13);
            this.lblViewName.TabIndex = 0;
            this.lblViewName.Text = "Tài khoản / vai trò:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tabs);
            this.Name = "MainForm";
            this.Text = "NHOM 09 - Quản trị CSDL Oracle";
            this.tabs.ResumeLayout(false);
            this.tabConn.ResumeLayout(false);
            this.grpConn.ResumeLayout(false);
            this.grpConn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.grpUserActions.ResumeLayout(false);
            this.grpUserActions.PerformLayout();
            this.tabRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).EndInit();
            this.grpRoleActions.ResumeLayout(false);
            this.grpRoleActions.PerformLayout();
            this.tabGrant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrivs)).EndInit();
            this.grpGrant.ResumeLayout(false);
            this.grpGrant.PerformLayout();
            this.tabView.ResumeLayout(false);
            this.tabView.PerformLayout();
            this.ResumeLayout(false);

            this.cboViewKind.SelectedIndex = 0;
        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabConn;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.TabPage tabGrant;
        private System.Windows.Forms.TabPage tabView;

        private System.Windows.Forms.GroupBox grpConn;
        private System.Windows.Forms.CheckBox chkSysdba;
        private System.Windows.Forms.Button btnApplyConn;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.TextBox txtConnPreview;
        private System.Windows.Forms.Label lblConnPreview;
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

        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.GroupBox grpUserActions;
        private System.Windows.Forms.Button btnUserUnlock;
        private System.Windows.Forms.Button btnUserLock;
        private System.Windows.Forms.Button btnUserDrop;
        private System.Windows.Forms.Button btnUserAlterPass;
        private System.Windows.Forms.Button btnUserCreate;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnUsersRefresh;

        private System.Windows.Forms.DataGridView gridRoles;
        private System.Windows.Forms.GroupBox grpRoleActions;
        private System.Windows.Forms.Button btnRoleDrop;
        private System.Windows.Forms.Button btnRoleCreate;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Button btnRolesRefresh;

        private System.Windows.Forms.GroupBox grpGrant;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Button btnGrant;
        private System.Windows.Forms.CheckBox chkWithOption;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.TextBox txtObjectName;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.RadioButton radGrantObjPriv;
        private System.Windows.Forms.RadioButton radGrantSysPriv;
        private System.Windows.Forms.RadioButton radGrantRole;
        private System.Windows.Forms.TextBox txtGrantWhat;
        private System.Windows.Forms.Label lblGrantWhat;
        private System.Windows.Forms.TextBox txtGrantee;
        private System.Windows.Forms.Label lblGrantee;

        private System.Windows.Forms.DataGridView gridPrivs;
        private System.Windows.Forms.Button btnViewPrivs;
        private System.Windows.Forms.ComboBox cboViewKind;
        private System.Windows.Forms.Label lblViewKind;
        private System.Windows.Forms.TextBox txtViewName;
        private System.Windows.Forms.Label lblViewName;
    }
}

