using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ColumnSelectForm : Form
    {
        public IReadOnlyList<string> SelectedColumns =>
            list.CheckedItems.Cast<object>().Select(x => x.ToString()).Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

        public ColumnSelectForm(IEnumerable<string> columns)
        {
            InitializeComponent();
            foreach (var c in columns ?? Enumerable.Empty<string>())
                list.Items.Add(c, false);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Items.Count; i++) list.SetItemChecked(i, true);
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Items.Count; i++) list.SetItemChecked(i, false);
        }
    }
}

