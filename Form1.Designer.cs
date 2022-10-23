
namespace AccountingTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemСategoriesСщые = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExpenses = new System.Windows.Forms.ToolStripMenuItem();
            this.еoolStripMenuItemStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemСategoriesСщые,
            this.toolStripMenuItemExpenses,
            this.еoolStripMenuItemStatistics});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemСategoriesСщые
            // 
            this.toolStripMenuItemСategoriesСщые.Name = "toolStripMenuItemСategoriesСщые";
            this.toolStripMenuItemСategoriesСщые.Size = new System.Drawing.Size(144, 24);
            this.toolStripMenuItemСategoriesСщые.Text = "Категории затрат";
            this.toolStripMenuItemСategoriesСщые.Click += new System.EventHandler(this.toolStripMenuItemСategoriesCost_Click);
            // 
            // toolStripMenuItemExpenses
            // 
            this.toolStripMenuItemExpenses.Name = "toolStripMenuItemExpenses";
            this.toolStripMenuItemExpenses.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItemExpenses.Text = "Расходы";
            this.toolStripMenuItemExpenses.Click += new System.EventHandler(this.toolStripMenuItemExpenses_Click);
            // 
            // еoolStripMenuItemStatistics
            // 
            this.еoolStripMenuItemStatistics.Name = "еoolStripMenuItemStatistics";
            this.еoolStripMenuItemStatistics.Size = new System.Drawing.Size(98, 24);
            this.еoolStripMenuItemStatistics.Text = "Статистика";
            this.еoolStripMenuItemStatistics.Click += new System.EventHandler(this.toolStripMenuItemstatistics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Программа учета расходов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemСategoriesСщые;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExpenses;
        private System.Windows.Forms.ToolStripMenuItem еoolStripMenuItemStatistics;
    }
}

