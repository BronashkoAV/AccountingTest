using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountingTest
{
    public partial class FormCategoryAdd : Form
    {
        private static FormCategoryAdd _instance;

        public static FormCategoryAdd Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormCategoryAdd();
                }
                return _instance;
            }
        }
        public FormCategoryAdd()
        {
            InitializeComponent();
        }

        private void FormCategoryAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _instance.Close();
        }
    }
}
