using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;

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


        private void FormExpensesAdd_Load(object sender, EventArgs e)
        {
            dateTimeBuy.Value = DateTime.Now;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Category FROM CategoryDB", SQLManager.SqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            comboBoxCategory.DataSource = dataSet.Tables[0];
            comboBoxCategory.DisplayMember = "Категории";
            comboBoxCategory.ValueMember = "Category";

            textBoxMoney.Text = string.Format("{0:#,##0.00}", 0.0);
        }
        private void FormExpensesAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase(
                dateTimeBuy.Value,
                comboBoxCategory.Text,
                decimal.Parse(textBoxMoney.Text),
                textBoxComment.Text);

            SqlCommand command = new SqlCommand(
                $"INSERT INTO [Accounting] (Category, Cost, Date, Comment)" +
                $"VALUES (@Category, @Cost, @Date, @Comment)",
                SQLManager.SqlConnection);
            command.Parameters.AddWithValue("@Category", purchase.Category);
            command.Parameters.AddWithValue("@Cost", purchase.Cost);
            command.Parameters.AddWithValue("@Date", $"{purchase.DateBuy.Month}/{purchase.DateBuy.Day}/{purchase.DateBuy.Year}");
            command.Parameters.AddWithValue("@Comment", purchase.Comment);
            command.ExecuteNonQuery();

            FormExpenses.RefreshDB();
            _instance.Close();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _instance.Close();
        }
    }
}
