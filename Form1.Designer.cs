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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox_chart = new System.Windows.Forms.PictureBox();
            this.button_createPoints = new System.Windows.Forms.Button();
            this.button_createChart = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 454);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(272, 47);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_createChart);
            this.Controls.Add(this.button_createPoints);
            this.Controls.Add(this.pictureBox_chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_chart;
        private System.Windows.Forms.Button button_createPoints;
        private System.Windows.Forms.Button button_createChart;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

