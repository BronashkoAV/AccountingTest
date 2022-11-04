using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

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
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO CategoryDB (Category) VALUES (N'{textBox1.Text}')", SQLManager.SqlConnection);
            command.ExecuteNonQuery();
            FormCategoriesCost.RefreshDB();
            _instance.Close();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _instance.Close();
        }
        private void FormCategoryAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonOk_Click(sender, e);
            }
        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonOk_Click(sender, e);
            }
        }

    }
}
