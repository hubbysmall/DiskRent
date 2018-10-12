using Models;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class ComponentDisk : UserControl
    {
        private RentDbContext context;

        private DiskService service;

        public ComponentDisk()
        {
            InitializeComponent();
            context = new RentDbContext();
            service = new DiskService(context);

            panel.Hide();
            LoadData();
        }


        private void LoadData()
        {
            try
            {
                List<Disk> list = service.getDiskList();
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(e.ColumnIndex.ToString()) != 6)
            {
                service.updateDisk(new Disk
                {
                    Id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value),
                    name = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[1].Value),
                    genre = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[2].Value),
                    description = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[3].Value),
                    country = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[5].Value),
                    director = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[4].Value)
                });

                LoadData();
                MessageBox.Show("Ячейка изменена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(e.ColumnIndex.ToString()) == 6)
            {
                if ((Boolean)dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == true)
                {
                    service.returnDisk(new Disk
                    {
                        Id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value),
                    });
                    MessageBox.Show("Забираем с рук", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    service.giveInRentDisk(new Disk
                    {
                        Id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value),
                    });
                    MessageBox.Show("Отдаем на руки", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            };
        }

        private void button_deleteDisk_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        service.deleteDisk(new Disk
                        {
                            Id = id,
                        });
                        LoadData();
                        MessageBox.Show("Запись удалена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_addDisk_Click(object sender, EventArgs e)
        {
            panel.Show();
        }

        private void button_hidePanel_Click(object sender, EventArgs e)
        {
            panel.Hide();
        }

        private void button_saveDisk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_nameDisk.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox_genreDisk.Text))
            {
                MessageBox.Show("Заполните жанр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox_descriptionDisk.Text))
            {
                MessageBox.Show("Заполните описание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox_countryDisk.Text))
            {
                MessageBox.Show("Заполните страну", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox_directorDisk.Text))
            {
                MessageBox.Show("Заполните режиссера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                service.addDisk(new Disk
                {
                    name = Convert.ToString(textBox_nameDisk.Text),
                    genre = Convert.ToString(textBox_genreDisk.Text),
                    description = Convert.ToString(textBox_descriptionDisk.Text),
                    country = Convert.ToString(textBox_countryDisk.Text),
                    director = Convert.ToString(textBox_directorDisk.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}





