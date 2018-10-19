using CsvHelper;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public class BackUpCSV : Component
    {
        private RentDbContext context;

        public BackUpCSV()
        {
            context = new RentDbContext();
        }

        public Boolean testCon()
        {
            try
            {
                Disk element = context.Disks.First();
                if (element != null)
                    return true;
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message, "Ошhhhhhhибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        public void saveToCSV()
        {
            if (testCon())
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (var sw = new StreamWriter(sfd.FileName))
                        {
                            var writer = new CsvWriter(sw);
                            writer.WriteHeader(typeof(Disk));
                            writer.NextRecord();
                            foreach (Disk d in context.Disks.ToList() as List<Disk>)
                            {
                                writer.WriteRecord(d);
                                writer.NextRecord();
                            }
                        }
                        MessageBox.Show("saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }        
        }
    }
}
