using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountingTest
{
    public partial class FormCategoriesCost : Form
    {
        private static FormCategoriesCost _instance;

        public static FormCategoriesCost Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormCategoriesCost();
                }
                return _instance;
            }
        }

        public FormCategoriesCost()
        {
            InitializeComponent();
        }

        private void FormCategoriesCost_Load(object sender, EventArgs e)
        {

        }

        private void FormCategoriesCost_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormCategoryAdd.Instance.ShowDialog();
        }
    }
}
