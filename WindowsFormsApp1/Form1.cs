using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnTest_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            try
            {
                var cs = OracleDb.BuildConnectionString(
                    host: txtHost.Text,
                    port: (int)numPort.Value,
                    serviceName: txtService.Text,
                    userId: txtUser.Text,
                    password: txtPass.Text,
                    asSysdba: chkSysdba.Checked);

                AppendResult("Đang thử kết nối (nhập tay)...");
                await OracleDb.TestConnectionAsync(cs);
                AppendResult("OK: Kết nối Oracle thành công.");
            }
            catch (Exception ex)
            {
                AppendResult("LỖI: " + ex.Message);
            }
            finally
            {
                SetBusy(false);
            }
        }

        private async void btnUseConfig_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            try
            {
                var cs = OracleDb.GetConnectionStringFromConfig();
                cs = OracleDb.WithSysdba(cs, chkSysdba.Checked);
                AppendResult("Đang thử kết nối (từ App.config: OracleDb)...");
                await OracleDb.TestConnectionAsync(cs);
                AppendResult("OK: Kết nối Oracle thành công.");
            }
            catch (Exception ex)
            {
                AppendResult("LỖI: " + ex.Message);
            }
            finally
            {
                SetBusy(false);
            }
        }

        private void AppendResult(string message)
        {
            txtResult.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}");
        }

        private void SetBusy(bool busy)
        {
            btnTest.Enabled = !busy;
            btnUseConfig.Enabled = !busy;
            UseWaitCursor = busy;
        }
    }
}
