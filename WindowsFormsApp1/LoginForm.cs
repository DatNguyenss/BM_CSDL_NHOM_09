using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public string ConnectionString { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            numPort.Value = 1521;
            txtHost.Text = "localhost";
            txtService.Text = "XEPDB1";
            txtUser.Text = "sys";
            chkSysdba.Checked = true;
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            try
            {
                var cs = OracleDb.BuildConnectionString(
                    host: txtHost.Text,
                    port: (int)numPort.Value,
                    serviceName: txtService.Text,
                    userId: txtUser.Text,
                    password: txtPassword.Text,
                    asSysdba: false);

                cs = OracleDb.WithSysdba(cs, chkSysdba.Checked);
                txtPreview.Text = cs;
            }
            catch
            {
                txtPreview.Text = string.Empty;
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            try
            {
                var cs = txtPreview.Text;
                await OracleDb.TestConnectionAsync(cs);
                ConnectionString = cs;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "NHOM 09 - Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConnect.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtHost_TextChanged(object sender, EventArgs e) => UpdatePreview();
        private void numPort_ValueChanged(object sender, EventArgs e) => UpdatePreview();
        private void txtService_TextChanged(object sender, EventArgs e) => UpdatePreview();
        private void txtUser_TextChanged(object sender, EventArgs e) => UpdatePreview();
        private void txtPassword_TextChanged(object sender, EventArgs e) => UpdatePreview();
        private void chkSysdba_CheckedChanged(object sender, EventArgs e) => UpdatePreview();
    }
}

