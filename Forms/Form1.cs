using CsvHelper;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
