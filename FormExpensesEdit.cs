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
    public partial class FormExpensesEdit : Form
    {
        private static FormExpensesEdit _instance;
        public static FormExpensesEdit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormExpensesEdit();
                }
                return _instance;
            }
        }
        public FormExpensesEdit()
        {
            InitializeComponent();
        }

        private Purchase _purchase;
        public Purchase Purchase
        {
            get
            {
                return _purchase;
            }
            set
            {
                _purchase = Purchase;
            }
        }
        private void FormExpensesAdd_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Category FROM CategoryDB", SQLManager.SqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            comboBoxCategory.DataSource = dataSet.Tables[0];
            comboBoxCategory.DisplayMember = "Категории";
            comboBoxCategory.ValueMember = "Category";

            textBoxMoney.Text = string.Format("{0:#,##0.00}", 0.0);

            _purchase = FormExpenses.Instance.Purchase;
            dateTimeBuy.Value = _purchase.DateBuy;
            comboBoxCategory.SelectedValue = _purchase.Category;
            textBoxMoney.Text = _purchase.Cost.ToString();
            textBoxComment.Text = _purchase.Comment;
        }
        private void FormExpensesAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            _purchase = new Purchase(
                 dateTimeBuy.Value,
            comboBoxCategory.Text,
                decimal.Parse(textBoxMoney.Text),
                 textBoxComment.Text);

            SqlCommand command = new SqlCommand(
                $"UPDATE [Accounting] " +
                $"SET Category = @Category, " +
                $"Cost = @Cost, " +
                $"Date = @Date, " +
                $"Comment = @Comment " +
                $"WHERE Id = @id",
                SQLManager.SqlConnection);
            command.Parameters.AddWithValue("@id", FormExpenses.Id);
            command.Parameters.AddWithValue("@Category", _purchase.Category);
            command.Parameters.AddWithValue("@Cost", _purchase.Cost);
            command.Parameters.AddWithValue("@Date", $"{_purchase.DateBuy.Month}/{_purchase.DateBuy.Day}/{_purchase.DateBuy.Year}");
            command.Parameters.AddWithValue("@Comment", _purchase.Comment);
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
