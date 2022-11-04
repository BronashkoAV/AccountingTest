using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }

        private void FormStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
