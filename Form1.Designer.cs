namespace quarterPoints
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
            this.pictureBox_chart = new System.Windows.Forms.PictureBox();
            this.button_createPoints = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_chart
            // 
            this.pictureBox_chart.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_chart.Name = "pictureBox_chart";
            this.pictureBox_chart.Size = new System.Drawing.Size(775, 340);
            this.pictureBox_chart.TabIndex = 0;
            this.pictureBox_chart.TabStop = false;
            // 
            // button_createPoints
            // 
            this.button_createPoints.Location = new System.Drawing.Point(297, 383);
            this.button_createPoints.Name = "button_createPoints";
            this.button_createPoints.Size = new System.Drawing.Size(168, 36);
            this.button_createPoints.TabIndex = 1;
            this.button_createPoints.Text = "button1";
            this.button_createPoints.UseVisualStyleBackColor = true;
            this.button_createPoints.Click += new System.EventHandler(this.button_createPoints_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_createPoints);
            this.Controls.Add(this.pictureBox_chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_chart;
        private System.Windows.Forms.Button button_createPoints;
    }
}

