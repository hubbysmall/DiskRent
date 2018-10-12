namespace Forms
{
    partial class ComponentDisk
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.textBox_nameDisk = new System.Windows.Forms.TextBox();
            this.textBox_genreDisk = new System.Windows.Forms.TextBox();
            this.textBox_descriptionDisk = new System.Windows.Forms.TextBox();
            this.textBox_countryDisk = new System.Windows.Forms.TextBox();
            this.textBox_directorDisk = new System.Windows.Forms.TextBox();
            this.button_saveDisk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_addDisk = new System.Windows.Forms.Button();
            this.button_deleteDisk = new System.Windows.Forms.Button();
            this.button_hidePanel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(667, 254);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel.Controls.Add(this.button_hidePanel);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.button_saveDisk);
            this.panel.Controls.Add(this.textBox_directorDisk);
            this.panel.Controls.Add(this.textBox_countryDisk);
            this.panel.Controls.Add(this.textBox_descriptionDisk);
            this.panel.Controls.Add(this.textBox_genreDisk);
            this.panel.Controls.Add(this.textBox_nameDisk);
            this.panel.Location = new System.Drawing.Point(688, 18);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(272, 236);
            this.panel.TabIndex = 1;
            // 
            // textBox_nameDisk
            // 
            this.textBox_nameDisk.Location = new System.Drawing.Point(99, 15);
            this.textBox_nameDisk.Name = "textBox_nameDisk";
            this.textBox_nameDisk.Size = new System.Drawing.Size(145, 20);
            this.textBox_nameDisk.TabIndex = 0;
            // 
            // textBox_genreDisk
            // 
            this.textBox_genreDisk.Location = new System.Drawing.Point(99, 51);
            this.textBox_genreDisk.Name = "textBox_genreDisk";
            this.textBox_genreDisk.Size = new System.Drawing.Size(145, 20);
            this.textBox_genreDisk.TabIndex = 1;
            // 
            // textBox_descriptionDisk
            // 
            this.textBox_descriptionDisk.Location = new System.Drawing.Point(99, 88);
            this.textBox_descriptionDisk.Name = "textBox_descriptionDisk";
            this.textBox_descriptionDisk.Size = new System.Drawing.Size(145, 20);
            this.textBox_descriptionDisk.TabIndex = 2;
            // 
            // textBox_countryDisk
            // 
            this.textBox_countryDisk.Location = new System.Drawing.Point(99, 123);
            this.textBox_countryDisk.Name = "textBox_countryDisk";
            this.textBox_countryDisk.Size = new System.Drawing.Size(145, 20);
            this.textBox_countryDisk.TabIndex = 3;
            // 
            // textBox_directorDisk
            // 
            this.textBox_directorDisk.Location = new System.Drawing.Point(99, 158);
            this.textBox_directorDisk.Name = "textBox_directorDisk";
            this.textBox_directorDisk.Size = new System.Drawing.Size(145, 20);
            this.textBox_directorDisk.TabIndex = 4;
            // 
            // button_saveDisk
            // 
            this.button_saveDisk.Location = new System.Drawing.Point(156, 194);
            this.button_saveDisk.Name = "button_saveDisk";
            this.button_saveDisk.Size = new System.Drawing.Size(104, 32);
            this.button_saveDisk.TabIndex = 5;
            this.button_saveDisk.Text = "Сохранить";
            this.button_saveDisk.UseVisualStyleBackColor = true;
            this.button_saveDisk.Click += new System.EventHandler(this.button_saveDisk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Жанр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Страна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Режиссер";
            // 
            // button_addDisk
            // 
            this.button_addDisk.Location = new System.Drawing.Point(338, 260);
            this.button_addDisk.Name = "button_addDisk";
            this.button_addDisk.Size = new System.Drawing.Size(135, 36);
            this.button_addDisk.TabIndex = 2;
            this.button_addDisk.Text = "Добавить";
            this.button_addDisk.UseVisualStyleBackColor = true;
            this.button_addDisk.Click += new System.EventHandler(this.button_addDisk_Click);
            // 
            // button_deleteDisk
            // 
            this.button_deleteDisk.Location = new System.Drawing.Point(185, 260);
            this.button_deleteDisk.Name = "button_deleteDisk";
            this.button_deleteDisk.Size = new System.Drawing.Size(135, 36);
            this.button_deleteDisk.TabIndex = 3;
            this.button_deleteDisk.Text = "Удалить";
            this.button_deleteDisk.UseVisualStyleBackColor = true;
            this.button_deleteDisk.Click += new System.EventHandler(this.button_deleteDisk_Click);
            // 
            // button_hidePanel
            // 
            this.button_hidePanel.Location = new System.Drawing.Point(10, 206);
            this.button_hidePanel.Name = "button_hidePanel";
            this.button_hidePanel.Size = new System.Drawing.Size(102, 20);
            this.button_hidePanel.TabIndex = 11;
            this.button_hidePanel.Text = "Скрыть панель";
            this.button_hidePanel.UseVisualStyleBackColor = true;
            this.button_hidePanel.Click += new System.EventHandler(this.button_hidePanel_Click);
            // 
            // ComponentDisk
            // 
            this.Controls.Add(this.button_deleteDisk);
            this.Controls.Add(this.button_addDisk);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.Name = "ComponentDisk";
            this.Size = new System.Drawing.Size(1044, 306);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBox_nameDisk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_saveDisk;
        private System.Windows.Forms.TextBox textBox_directorDisk;
        private System.Windows.Forms.TextBox textBox_countryDisk;
        private System.Windows.Forms.TextBox textBox_descriptionDisk;
        private System.Windows.Forms.TextBox textBox_genreDisk;
        private System.Windows.Forms.Button button_addDisk;
        private System.Windows.Forms.Button button_deleteDisk;
        private System.Windows.Forms.Button button_hidePanel;
    }
}
