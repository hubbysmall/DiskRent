using Microsoft.Office.Interop.Excel;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class ComponentReport : Component
    {
        private RentDbContext context;

        public ComponentReport()
        {
            InitializeComponent();
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

        public void createExcel(string FileName)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                //или создаем excel-файл, или открываем существующий
                if (File.Exists(FileName))
                {
                    excel.Workbooks.Open(FileName, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing);
                }
                else
                {
                    excel.SheetsInNewWorkbook = 1;
                    excel.Workbooks.Add(Type.Missing);
                    excel.Workbooks[1].SaveAs(FileName, XlFileFormat.xlExcel8, Type.Missing,
                        Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }

                Sheets excelsheets = excel.Workbooks[1].Worksheets;
                var excelworksheet = (Worksheet)excelsheets.get_Item(1);
                excelworksheet.Cells.Clear();
                Microsoft.Office.Interop.Excel.Range excelcells = excelworksheet.get_Range("A1", "E1");
                excelcells.Merge(Type.Missing);
                excelcells.Font.Bold = true;
                excelcells.Value2 = "Отчет о том, какие диски в данный момент на руках (" + DateTime.Now.ToShortDateString() + ")";
                excelcells.RowHeight = 25;
                excelcells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                excelcells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                excelcells.Font.Name = "Times New Roman";
                excelcells.Font.Size = 12;

                excelcells = excelworksheet.get_Range("A2", "A2");
                excelcells.Font.Name = "Times New Roman";
                excelcells.Font.Size = 12;
                excelcells.Font.Bold = true;
                excelcells.Value2 = "Название";
                excelcells = excelcells.get_Offset(0, 1);
                excelcells.Font.Name = "Times New Roman";
                excelcells.Font.Size = 12;
                excelcells.Font.Bold = true;
                excelcells.Value2 = "Жанр";
                excelcells = excelcells.get_Offset(0, 1);
                excelcells.Font.Name = "Times New Roman";
                excelcells.Font.Size = 12;
                excelcells.Font.Bold = true;
                excelcells.ColumnWidth = 25;
                excelcells.Value2 = "Описание";
                excelcells = excelcells.get_Offset(0, 1);
                excelcells.Font.Name = "Times New Roman";
                excelcells.Font.Size = 12;
                excelcells.Font.Bold = true;
                excelcells.Value2 = "Страна";
                excelcells = excelcells.get_Offset(0, 1);
                excelcells.Font.Name = "Times New Roman";
                excelcells.Font.Size = 12;
                excelcells.Font.Bold = true;
                excelcells.Value2 = "Директор";

                var dict = context.Disks.Where(rec => rec.takenByClient == true).ToList();
                if (dict != null)
                {
                    excelcells = excelworksheet.get_Range("A3", "A3");
                    foreach (var elem in dict)
                    {
                        excelcells.Font.Name = "Times New Roman";
                        excelcells.Font.Size = 12;
                        excelcells.Value2 = elem.name;
                        excelcells = excelcells.get_Offset(0, 1);
                        excelcells.Font.Name = "Times New Roman";
                        excelcells.Font.Size = 12;
                        excelcells.Value2 = elem.genre;
                        excelcells = excelcells.get_Offset(0, 1);
                        excelcells.Font.Name = "Times New Roman";
                        excelcells.Font.Size = 12;
                        excelcells.Value2 = elem.description;
                        excelcells = excelcells.get_Offset(0, 1);
                        excelcells.Font.Name = "Times New Roman";
                        excelcells.Font.Size = 12;
                        excelcells.Value2 = elem.country;
                        excelcells = excelcells.get_Offset(0, 1);
                        excelcells.Font.Name = "Times New Roman";
                        excelcells.Font.Size = 12;
                        excelcells.Value2 = elem.director;
                        excelcells = excelcells.get_Offset(1, -4);
                    }
                }
                excel.Workbooks[1].Save();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                excel.Quit();
            }
        }


        public void saveExcelFile()
        {
            if (testCon())
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "xls|*.xls|xlsx|*.xlsx"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        createExcel(sfd.FileName);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
    }
}
