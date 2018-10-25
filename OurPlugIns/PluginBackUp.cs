using CsvHelper;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurPlugIns
{
    [Export(typeof(IOperation))]
    public class PluginBackUp: IOperation
    {
        public String Operation => "Make backup";

        public bool operate(DbSet<Disk> entities)
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
                        foreach (Disk d in entities.ToList() as List<Disk>)
                        {
                            writer.WriteRecord(d);
                            writer.NextRecord();
                        }
                    }
                    MessageBox.Show("saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            
        }
    }
}
