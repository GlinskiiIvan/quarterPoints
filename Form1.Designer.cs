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
            this.button_createChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label4_count = new System.Windows.Forms.Label();
            this.label3_count = new System.Windows.Forms.Label();
            this.label2_count = new System.Windows.Forms.Label();
            this.label1_count = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_chart
            // 
            this.pictureBox_chart.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_chart.Name = "pictureBox_chart";
            this.pictureBox_chart.Size = new System.Drawing.Size(305, 305);
            this.pictureBox_chart.TabIndex = 0;
            this.pictureBox_chart.TabStop = false;
            // 
            // button_createPoints
            // 
            this.button_createPoints.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_createPoints.Location = new System.Drawing.Point(13, 377);
            this.button_createPoints.Name = "button_createPoints";
            this.button_createPoints.Size = new System.Drawing.Size(305, 36);
            this.button_createPoints.TabIndex = 1;
            this.button_createPoints.Text = "Сформировать точки";
            this.button_createPoints.UseVisualStyleBackColor = true;
            this.button_createPoints.Click += new System.EventHandler(this.button_createPoints_Click);
            // 
            // button_createChart
            // 
            this.button_createChart.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_createChart.Location = new System.Drawing.Point(13, 335);
            this.button_createChart.Name = "button_createChart";
            this.button_createChart.Size = new System.Drawing.Size(305, 36);
            this.button_createChart.TabIndex = 2;
            this.button_createChart.Text = "Построить координатную сетку";
            this.button_createChart.UseVisualStyleBackColor = true;
            this.button_createChart.Click += new System.EventHandler(this.button_createChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Первая четверть:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вторая четверть:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Третья четверть:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Четвертая четверть:";
            // 
            // label4_count
            // 
            this.label4_count.AutoSize = true;
            this.label4_count.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4_count.Location = new System.Drawing.Point(187, 549);
            this.label4_count.Name = "label4_count";
            this.label4_count.Size = new System.Drawing.Size(19, 21);
            this.label4_count.TabIndex = 7;
            this.label4_count.Text = "0";
            // 
            // label3_count
            // 
            this.label3_count.AutoSize = true;
            this.label3_count.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3_count.Location = new System.Drawing.Point(187, 519);
            this.label3_count.Name = "label3_count";
            this.label3_count.Size = new System.Drawing.Size(19, 21);
            this.label3_count.TabIndex = 8;
            this.label3_count.Text = "0";
            // 
            // label2_count
            // 
            this.label2_count.AutoSize = true;
            this.label2_count.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_count.Location = new System.Drawing.Point(187, 489);
            this.label2_count.Name = "label2_count";
            this.label2_count.Size = new System.Drawing.Size(19, 21);
            this.label2_count.TabIndex = 9;
            this.label2_count.Text = "0";
            // 
            // label1_count
            // 
            this.label1_count.AutoSize = true;
            this.label1_count.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_count.Location = new System.Drawing.Point(187, 459);
            this.label1_count.Name = "label1_count";
            this.label1_count.Size = new System.Drawing.Size(19, 21);
            this.label1_count.TabIndex = 10;
            this.label1_count.Text = "0";
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(13, 419);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(305, 29);
            this.button_clear.TabIndex = 11;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1_count);
            this.Controls.Add(this.label2_count);
            this.Controls.Add(this.label3_count);
            this.Controls.Add(this.label4_count);
            this.Controls.Add(this.button_createChart);
            this.Controls.Add(this.button_createPoints);
            this.Controls.Add(this.pictureBox_chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_chart;
        private System.Windows.Forms.Button button_createPoints;
        private System.Windows.Forms.Button button_createChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label4_count;
        private System.Windows.Forms.Label label3_count;
        private System.Windows.Forms.Label label2_count;
        private System.Windows.Forms.Label label1_count;
        private System.Windows.Forms.Button button_clear;
    }
}

