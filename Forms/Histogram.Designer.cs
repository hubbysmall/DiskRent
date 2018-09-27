namespace Forms
{
    partial class Histogram
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
            this.do_statistics_button = new System.Windows.Forms.Button();
            this.picHistoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHistoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // do_statistics_button
            // 
            this.do_statistics_button.Location = new System.Drawing.Point(416, 238);
            this.do_statistics_button.Name = "do_statistics_button";
            this.do_statistics_button.Size = new System.Drawing.Size(75, 23);
            this.do_statistics_button.TabIndex = 0;
            this.do_statistics_button.Text = "do statistics";
            this.do_statistics_button.UseVisualStyleBackColor = true;
            this.do_statistics_button.Click += new System.EventHandler(this.do_statistics_button_Click);
            // 
            // picHistoPictureBox
            // 
            this.picHistoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.picHistoPictureBox.Name = "picHistoPictureBox";
            this.picHistoPictureBox.Size = new System.Drawing.Size(488, 229);
            this.picHistoPictureBox.TabIndex = 1;
            this.picHistoPictureBox.TabStop = false;
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picHistoPictureBox);
            this.Controls.Add(this.do_statistics_button);
            this.Name = "Histogram";
            this.Size = new System.Drawing.Size(494, 264);
            ((System.ComponentModel.ISupportInitialize)(this.picHistoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button do_statistics_button;
        private System.Windows.Forms.PictureBox picHistoPictureBox;
    }
}
