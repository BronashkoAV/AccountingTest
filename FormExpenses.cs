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

        private static int _id;
        public static int Id
        {
            get
            {
                return _id;
            }
        }
        private Purchase _purchase;
        public Purchase Purchase
        {
            get
            {
                return _purchase;
            }
        }
        private void FormExpenses_Load(object sender, EventArgs e)
        {
            RefreshDB();
            dataGridViewExpenses.Columns[0].Visible = false;
            dataGridViewExpenses.Columns[1].HeaderText = "Дата";
            dataGridViewExpenses.Columns[2].HeaderText = "Категория";
            dataGridViewExpenses.Columns[3].HeaderText = "Стоимость";
            dataGridViewExpenses.Columns[4].HeaderText = "Комментарий";

            dateTimePickerFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePickerTo.Value = DateTime.Now;
        }

        private void FormExpenses_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormExpensesAdd.Instance.ShowDialog();
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.Rows.Count > 0 && dataGridViewExpenses.SelectedRows.Count > 0)
            {                
                _purchase = new Purchase((DateTime)dataGridViewExpenses.SelectedRows[0].Cells[1].Value,
                    dataGridViewExpenses.SelectedRows[0].Cells[2].Value.ToString(),
                    (decimal)dataGridViewExpenses.SelectedRows[0].Cells[3].Value,
                    dataGridViewExpenses.SelectedRows[0].Cells[4].Value.ToString());

                _purchase.Id = _id;
                FormExpensesEdit.Instance.ShowDialog();
            }
        }
        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.Rows.Count > 0 && dataGridViewExpenses.SelectedRows.Count > 0)
            {
                string id = dataGridViewExpenses.SelectedRows[0].Cells[0].Value.ToString();

                if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Уведомление",
    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand(@"DELETE FROM Accounting WHERE id = @id", SQLManager.SqlConnection);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                    RefreshDB();
                }
            }
        }

        private void ToolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDB();
        }

        public static void RefreshDB()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Accounting WHERE Date BETWEEN @datestart AND @dateend", SQLManager.SqlConnection);
            command.Parameters.AddWithValue("datestart", Instance.dateTimePickerFrom.Value);
            command.Parameters.AddWithValue("dateend", Instance.dateTimePickerTo.Value);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);

            Instance.dataGridViewExpenses.DataSource = dataSet.Tables[0];
        }

        private void DateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            RefreshDB();
        }

        private void DateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            RefreshDB();
        }

        private void DataGridViewExpenses_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.Rows.Count > 0 && dataGridViewExpenses.SelectedRows.Count > 0)
            {
                _id = Convert.ToInt32(dataGridViewExpenses.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
