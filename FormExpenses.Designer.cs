
namespace AccountingTest
{
    partial class FormExpenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpenses));
            this.toolStripExpenses = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBefore = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripExpenses
            // 
            this.toolStripExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripExpenses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripExpenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete,
            this.toolStripSeparator1,
            this.toolStripButtonRefresh});
            this.toolStripExpenses.Location = new System.Drawing.Point(0, 0);
            this.toolStripExpenses.Name = "toolStripExpenses";
            this.toolStripExpenses.Size = new System.Drawing.Size(882, 27);
            this.toolStripExpenses.TabIndex = 1;
            this.toolStripExpenses.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAdd.Text = "Добавить";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.ToolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonEdit.Text = "Редактировать";
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonDelete.Text = "Удалить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonRefresh.Text = "Обновить";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Период";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(98, 30);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(122, 27);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // dateTimePickerBefore
            // 
            this.dateTimePickerBefore.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBefore.Location = new System.Drawing.Point(226, 30);
            this.dateTimePickerBefore.Name = "dateTimePickerBefore";
            this.dateTimePickerBefore.Size = new System.Drawing.Size(122, 27);
            this.dateTimePickerBefore.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnCategory,
            this.ColumnPrice,
            this.ColumnComment});
            this.dataGridView1.Location = new System.Drawing.Point(13, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(857, 482);
            this.dataGridView1.TabIndex = 5;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.MinimumWidth = 6;
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.Width = 125;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.HeaderText = "Категория";
            this.ColumnCategory.MinimumWidth = 6;
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.Width = 125;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Стоимость";
            this.ColumnPrice.MinimumWidth = 6;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.Width = 125;
            // 
            // ColumnComment
            // 
            this.ColumnComment.HeaderText = "Комментарий";
            this.ColumnComment.MinimumWidth = 6;
            this.ColumnComment.Name = "ColumnComment";
            this.ColumnComment.Width = 125;
            // 
            // FormExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerBefore);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripExpenses);
            this.Name = "FormExpenses";
            this.Text = "Расходы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormExpenses_FormClosed);
            this.Load += new System.EventHandler(this.FormExpenses_Load);
            this.toolStripExpenses.ResumeLayout(false);
            this.toolStripExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripExpenses;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerBefore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComment;
    }
}