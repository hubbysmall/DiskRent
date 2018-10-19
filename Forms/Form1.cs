using Models;
using Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            backUpCSV1.saveToCSV();
            //backUpCSV1.examp(); MessageBox.Show("saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            diskBindingSource.DataSource = new List<Disk>();
        }

        private void button_createReport_Click(object sender, EventArgs e)
        {
            componentReport.saveExcelFile();
        }
    }
}
