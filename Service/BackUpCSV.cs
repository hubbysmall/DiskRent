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

        public void examp()
        {       
    

            Disk element2 = new Disk
            {
                name = "titanic",
                genre = "thriller",
                description = "titanic",
                country = "titanic",
                director = "titanic"
            };
            context.Disks.Add(element2);
            context.SaveChanges();

            Disk element3 = new Disk
            {
                name = "titanic",
                genre = "misteria",
                description = "titanic",
                country = "titanic",
                director = "titanic"
            };
            context.Disks.Add(element3);
            context.SaveChanges();

            Disk element4 = new Disk
            {
                name = "titanic",
                genre = "shit",
                description = "titanic",
                country = "titanic",
                director = "titanic"
            };
            context.Disks.Add(element4);
            context.SaveChanges();

        }

        public void saveToCSV()
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
