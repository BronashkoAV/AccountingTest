using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountingTest
{
    public partial class FormExpensesAdd : Form
    {
        private static FormExpensesAdd _instance;

        public static FormExpensesAdd Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormExpensesAdd();
                }
                return _instance;
            }
        }
        public FormExpensesAdd()
        {
            InitializeComponent();
        }

        private void FormExpensesAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _instance.Close();
        }
    }
}
