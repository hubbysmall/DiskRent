namespace Forms
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.diskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonWrite = new System.Windows.Forms.Button();
            this.button_createReport = new System.Windows.Forms.Button();
            this.componentDisk1 = new Forms.ComponentDisk();
            this.histogram1 = new Forms.Histogram();
            this.backUpCSV1 = new Service.BackUpCSV();
            this.componentReport = new Service.ComponentReport();
            ((System.ComponentModel.ISupportInitialize)(this.diskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diskBindingSource
            // 
            this.diskBindingSource.DataSource = typeof(Models.Disk);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(671, 309);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(112, 23);
            this.buttonWrite.TabIndex = 2;
            this.buttonWrite.Text = "Сделать бэкап";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // button_createReport
            // 
            this.button_createReport.Location = new System.Drawing.Point(590, 267);
            this.button_createReport.Name = "button_createReport";
            this.button_createReport.Size = new System.Drawing.Size(75, 22);
            this.button_createReport.TabIndex = 4;
            this.button_createReport.Text = "Отчёт";
            this.button_createReport.UseVisualStyleBackColor = true;
            this.button_createReport.Click += new System.EventHandler(this.button_createReport_Click);
            // 
            // componentDisk1
            // 
            this.componentDisk1.Location = new System.Drawing.Point(0, -1);
            this.componentDisk1.Name = "componentDisk1";
            this.componentDisk1.Size = new System.Drawing.Size(1115, 304);
            this.componentDisk1.TabIndex = 3;
            // 
            // histogram1
            // 
            this.histogram1.Location = new System.Drawing.Point(772, 338);
            this.histogram1.Name = "histogram1";
            this.histogram1.Size = new System.Drawing.Size(331, 215);
            this.histogram1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 555);
            this.Controls.Add(this.button_createReport);
            this.Controls.Add(this.componentDisk1);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.histogram1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Histogram histogram1;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.BindingSource diskBindingSource;
        private Service.BackUpCSV backUpCSV1;
        private ComponentDisk componentDisk1;
        private System.Windows.Forms.Button button_createReport;
        private Service.ComponentReport componentReport;
    }
}

