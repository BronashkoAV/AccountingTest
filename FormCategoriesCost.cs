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
            RefreshDB();
            dataGridViewCategory.Columns[0].Visible = false;
            dataGridViewCategory.Columns[1].HeaderText = "Наименование";
        }
        private void FormCategoriesCost_Activated(object sender, EventArgs e)
        {
            RefreshDB();
        }
        private void FormCategoriesCost_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormCategoryAdd.Instance.ShowDialog();
        }
        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategory.Rows.Count > 0 && dataGridViewCategory.SelectedRows.Count > 0)
            {
                dataGridViewCategory.BeginEdit(false);
            }
        }
        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategory.Rows.Count > 0 && dataGridViewCategory.SelectedRows.Count > 0)
            {
                string id = dataGridViewCategory.SelectedRows[0].Cells[0].Value.ToString();
                SqlCommand command = new SqlCommand(@"DELETE FROM CategoryDB WHERE id = @id", SQLManager.SqlConnection);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                RefreshDB();
            }
        }
        private void ToolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDB();
        }
        private void ToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            ToolStripButtonAdd_Click(sender, e);
        }
        private void ToolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            ToolStripButtonEdit_Click(sender, e);
        }
        private void ToolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            ToolStripButtonDelete_Click(sender, e);
        }
        private void ToolStripMenuItemRefreshh_Click(object sender, EventArgs e)
        {
            ToolStripButtonRefresh_Click(sender, e);
        }

        private void DataGridViewCategory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridViewCategory.ClearSelection();
                var hit = dataGridViewCategory.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridViewCategory.Rows[hit.RowIndex].Selected = true;
                    dataGridViewCategory.CurrentCell = dataGridViewCategory.SelectedRows[0].Cells[1];
                    contextMenuStripRightClick.Show(dataGridViewCategory, e.Location);
                }
            }
        }
        private void DataGridViewCategory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCategory.Rows.Count > 0 &&
                dataGridViewCategory.SelectedRows.Count > 0 &&
                dataGridViewCategory.SelectedRows[0].Cells[1].Value.ToString().Length > 0)
            {
                SqlCommand command = new SqlCommand($"UPDATE CategoryDB " +
                    $"SET Category = (N'{dataGridViewCategory.SelectedRows[0].Cells[1].Value}')" +
                    $"WHERE id = (N'{dataGridViewCategory.SelectedRows[0].Cells[0].Value}')",
                    SQLManager.SqlConnection);
                command.ExecuteNonQuery();
            }
            else if(dataGridViewCategory.SelectedRows.Count > 0 && dataGridViewCategory.SelectedRows[0].Cells[1].Value.ToString().Length <= 0)
            {
                dataGridViewCategory.CancelEdit();
                MessageBox.Show("Нельзя вводить пустую строку");
            }
            RefreshDB();
        }
        public static void RefreshDB()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM CategoryDB", SQLManager.SqlConnection);

            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);

            Instance.dataGridViewCategory.DataSource = dataSet.Tables[0];
        }
    }
}
