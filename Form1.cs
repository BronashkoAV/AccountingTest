using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void ToolStripMenuItemСategoriesCost_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormCategoriesCost"]==null)
            {
                ShowForm(FormCategoriesCost.Instance);
            }
            else
            {
                FormCategoriesCost.Instance.Activate();
            }
        }

        private void ToolStripMenuItemExpenses_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormExpenses"] == null)
            {
                ShowForm(FormExpenses.Instance);
            }
            else
            {
                FormExpenses.Instance.Activate();
            }
        }

        private void ToolStripMenuItemstatistics_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormStatistics"] == null)
            {
                ShowForm(FormStatistics.Instance);
            }
            else
            {
                FormStatistics.Instance.Activate();
            }
        }
    }
}
