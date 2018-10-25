using Models;
using Service;
using Service.PluginInterfaceK;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        Manager manager;
        private RentDbContext context;

        public Form1()
        {
            InitializeComponent();
            context = new RentDbContext();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            backUpCSV1.saveToCSV();
            //backUpCSV1.examp(); MessageBox.Show("saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            diskBindingSource.DataSource = new List<Disk>();
            manager = new Manager();
            if(manager.Headers != null && manager.Headers.Length != 0)
            {
                comboBox1.Items.AddRange(manager.Headers);
                comboBox1.Text = comboBox1.Items[0].ToString();
            }
        }

        private void button_createReport_Click(object sender, EventArgs e)
        {
            componentReport.saveExcelFile();
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            if (manager == null)
                return;
            String chosen = comboBox1.Text;
            manager.Operations[chosen](context.Disks);
        }
    }
}
