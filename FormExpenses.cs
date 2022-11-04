using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountingTest
{
    public partial class FormExpenses : Form
    {
        private static FormExpenses _instance;

        public static FormExpenses Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormExpenses();
                }
                return _instance;
            }
        }
        public FormExpenses()
        {
            InitializeComponent();
        }

        private void FormExpenses_Load(object sender, EventArgs e)
        {

        }

        private void FormExpenses_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormExpensesAdd.Instance.ShowDialog();
        }
    }
}
