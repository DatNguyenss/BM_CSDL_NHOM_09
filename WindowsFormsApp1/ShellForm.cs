using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ShellForm : Form
    {
        private string _connectionString;

        public ShellForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void mnuConnect_Click(object sender, EventArgs e)
        {
            using (var login = new LoginForm())
            {
                if (login.ShowDialog(this) == DialogResult.OK)
                    _connectionString = login.ConnectionString;
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void mnuRefresh_Click(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == tabManage)
                await RefreshManageAsync();
            else if (tabs.SelectedTab == tabGrant)
                await RefreshGrantTargetsAsync();
            else if (tabs.SelectedTab == tabAudit)
                await RefreshAuditAsync();
        }

        private void ShowOracleError(Exception ex)
        {
            MessageBox.Show(this, ex.Message, "NHOM 09 - Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ===== TAB 1: Manage (Users/Roles) =====
        private async Task RefreshManageAsync()
        {
            try
            {
                var dtUsers = await OracleSql.QueryAsync(_connectionString,
                    "select username, account_status, created from dba_users order by username");
                gridManageUsers.DataSource = dtUsers;

                var dtRoles = await OracleSql.QueryAsync(_connectionString,
                    "select role, authentication_type from dba_roles order by role");
                gridManageRoles.DataSource = dtRoles;
            }
            catch (Exception ex) { ShowOracleError(ex); }
        }

        private async void btnManageRefresh_Click(object sender, EventArgs e) => await RefreshManageAsync();

        private async void btnUserCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = $"create user {OracleSql.Q(txtUserName.Text)} identified by {OracleSql.QLit(txtUserPass.Text)}";
                await OracleSql.ExecuteAsync(_connectionString, sql);
                await RefreshManageAsync();
            }
            catch (Exception ex) { ShowOracleError(ex); }
        }

        private async void btnUserAlter_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = $"alter user {OracleSql.Q(txtUserName.Text)} identified by {OracleSql.QLit(txtUserPass.Text)}";
                await OracleSql.ExecuteAsync(_connectionString, sql);
                await RefreshManageAsync();
            }
            catch (Exception ex) { ShowOracleError(ex); }
        }

        private async void btnUserDrop_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = $"drop user {OracleSql.Q(txtUserName.Text)} cascade";
                await OracleSql.ExecuteAsync(_connectionString, sql);
                await RefreshManageAsync();
            }
            catch (Exception ex) { ShowOracleError(ex); }
        }

        private async void btnRoleCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = $"create role {OracleSql.Q(txtRoleName.Text)}";
                await OracleSql.ExecuteAsync(_connectionString, sql);
                await RefreshManageAsync();
            }
            catch (Exception ex) { ShowOracleError(ex); }
        }

        private async void btnRoleDrop_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = $"drop role {OracleSql.Q(txtRoleName.Text)}";
                await OracleSql.ExecuteAsync(_connectionString, sql);
                await RefreshManageAsync();
            }
            catch (Exception ex) { ShowOracleError(ex); }
        }

        // ===== TAB 2: Grant =====
        private async Task RefreshGrantTargetsAsync()
        {
            try
            {
                var dt = await OracleSql.QueryAsync(_connectionString,
                    "select username as name, 'USER' as kind from dba_users " +
                    "union all " +
                    "select role as name, 'ROLE' as kind from dba_roles " +
                    "order by kind, name");

                cboGrantee.DisplayMember = "name";
                cboGrantee.ValueMember = "name";
                cboGrantee.DataSource = dt;
            }
            catch (Exception ex) { ShowOracleError(ex); }
        }

        private async void btnGrantRefreshTargets_Click(object sender, EventArgs e) => await RefreshGrantTargetsAsync();

        private async void btnPickColumns_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = txtObject.Text.Trim(); // schema.object
                var parts = obj.Split('.');
                if (parts.Length != 2) throw new InvalidOperationException("Object phải theo dạng SCHEMA.OBJECT");

                var owner = parts[0].ToUpperInvariant();
                var table = parts[1].ToUpperInvariant();

                var dt = await OracleSql.QueryAsync(_connectionString,
                    $"select column_name from dba_tab_columns where owner = {OracleSql.QLit(owner)} and table_name = {OracleSql.QLit(table)} order by column_id");

                var cols = dt.Rows.Cast<DataRow>().Select(r => r[0]?.ToString()).Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                using (var dlg = new ColumnSelectForm(cols))
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                        txtColumns.Text = string.Join(", ", dlg.SelectedColumns);
                }
            }
            catch (Exception ex) { ShowOracleError(ex); }
        }

        private void UpdateColumnButtonState()
        {
            var priv = (txtPrivilege.Text ?? "").Trim().ToLowerInvariant();
            btnPickColumns.Enabled = (priv == "select" || priv == "update");
        }

        private void txtPrivilege_TextChanged(object sender, EventArgs e) => UpdateColumnButtonState();

        private async void btnGrantExecute_Click(object sender, EventArgs e)
        {
            try
            {
                var grantee = cboGrantee.SelectedValue?.ToString() ?? "";
                var priv = txtPrivilege.Text.Trim();
                var withOption = chkWithGrantOption.Checked ? " with grant option" : "";

                string sql;
                if (radGrantRole.Checked)
                {
                    sql = $"grant {OracleSql.Q(priv)} to {OracleSql.Q(grantee)}{(chkWithGrantOption.Checked ? " with admin option" : "")}";
                }
                else if (radGrantSysPriv.Checked)
                {
                    sql = $"grant {priv} to {OracleSql.Q(grantee)}{(chkWithGrantOption.Checked ? " with admin option" : "")}";
                }
                else
                {
                    var obj = txtObject.Text.Trim();
                    var cols = txtColumns.Text.Trim();

                    if ((priv.Equals("select", StringComparison.OrdinalIgnoreCase) || priv.Equals("update", StringComparison.OrdinalIgnoreCase))
                        && !string.IsNullOrWhiteSpace(cols))
                        sql = $"grant {priv}({cols}) on {obj} to {OracleSql.Q(grantee)}{withOption}";
                    else
                        sql = $"grant {priv} on {obj} to {OracleSql.Q(grantee)}{withOption}";
                }

                await OracleSql.ExecuteAsync(_connectionString, sql);
            }
            catch (Exception ex) { ShowOracleError(ex); }
        }

        // ===== TAB 3: Audit/Revoke =====
        private async Task RefreshAuditAsync()
        {
            try
            {
                var filter = (txtAuditFilter.Text ?? "").Trim().ToUpperInvariant();
                var kind = (cboAuditKind.SelectedItem?.ToString() ?? "USER");

                var where = string.IsNullOrWhiteSpace(filter) ? "" : $" where grantee = {OracleSql.QLit(filter)}";

                var sql = $@"
select grantee,
       privilege as priv,
       owner || '.' || table_name as obj,
       cast(null as varchar2(4000)) as cols,
       grantable as opt
from dba_tab_privs{where}
union all
select grantee,
       privilege as priv,
       owner || '.' || table_name as obj,
       column_name as cols,
       grantable as opt
from dba_col_privs{where}
union all
select grantee,
       privilege as priv,
       cast(null as varchar2(4000)) as obj,
       cast(null as varchar2(4000)) as cols,
       admin_option as opt
from dba_sys_privs{where}
union all
select grantee,
       granted_role as priv,
       cast(null as varchar2(4000)) as obj,
       cast(null as varchar2(4000)) as cols,
       admin_option as opt
from dba_role_privs{where}";

                var dt = await OracleSql.QueryAsync(_connectionString, sql);
                gridAudit.DataSource = dt;
            }
            catch (Exception ex) { ShowOracleError(ex); }
        }

        private async void btnAuditRefresh_Click(object sender, EventArgs e) => await RefreshAuditAsync();

        private async void btnRevokeSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridAudit.CurrentRow == null) return;
                var r = ((DataRowView)gridAudit.CurrentRow.DataBoundItem)?.Row;
                if (r == null) return;

                var grantee = r["grantee"]?.ToString();
                var priv = r["priv"]?.ToString();
                var obj = r["obj"]?.ToString();
                var cols = r["cols"]?.ToString();

                string sql;
                if (!string.IsNullOrWhiteSpace(obj))
                {
                    if (!string.IsNullOrWhiteSpace(cols) &&
                        (priv.Equals("select", StringComparison.OrdinalIgnoreCase) || priv.Equals("update", StringComparison.OrdinalIgnoreCase)))
                        sql = $"revoke {priv}({cols}) on {obj} from {OracleSql.Q(grantee)}";
                    else
                        sql = $"revoke {priv} on {obj} from {OracleSql.Q(grantee)}";
                }
                else
                {
                    // sys priv hoặc role: không có obj
                    sql = $"revoke {priv} from {OracleSql.Q(grantee)}";
                }

                await OracleSql.ExecuteAsync(_connectionString, sql);
                await RefreshAuditAsync();
            }
            catch (Exception ex) { ShowOracleError(ex); }
        }
    }
}

