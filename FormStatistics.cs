using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountingTest
{
    public partial class FormStatistics : Form
    {
        private static FormStatistics _instance;

        public static FormStatistics Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormStatistics();
                }
                return _instance;
            }
        }
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            UpLoadDB();
        }

        private void FormStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private static void UpLoadDB()
        {
            //if (_instance.textBoxYear.Text.Length > 0 && Convert.ToInt32(_instance.textBoxYear.Text) == 2022)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Accounting", SQLManager.SqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                DataSet dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet);

                _instance.dataGridViewStatistics.DataSource = dataSet.Tables[0];
            }
        }

        private void TextBoxYear_TextChanged(object sender, EventArgs e)
        {
            UpLoadDB();
        }
    }
}
