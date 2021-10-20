using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quarterPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_createPoints_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox_chart.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            // Размеры области построения графика
            int width = pictureBox_chart.Width;
            int height = pictureBox_chart.Height;

            // Координатные оси
            graphics.DrawLine(pen, width / 2, 0, width / 2, height);
            graphics.DrawLine(pen, 0, height / 2, width, height / 2);

            // Стрелки координатных осей
            graphics.DrawLine(pen, width / 2, 0, width / 2 + 5, 10);
            graphics.DrawLine(pen, width / 2, 0, width / 2 - 5, 10);
            graphics.DrawLine(pen, width, height / 2, width - 10, height / 2 + 5);
            graphics.DrawLine(pen, width, height / 2, width - 10, height / 2 - 5);

            // Подписи координатных осей
            graphics.DrawString("Y", new Font("10_IC_1", 12), Brushes.Black, width / 2 + 10, -5);
            graphics.DrawString("X", new Font("10_IC_1", 12), Brushes.Black, width - 15, height / 2 + 10); //width, height / 2


            // Координатная сетка и отметки на координатных осях
            int lx = -width / 40 + 1;
            for (int i = 20; i < width - 20; i += 20)
            {
                if (lx != 0)
                {
                    graphics.DrawLine(new Pen(Color.Gray, 1), 0 + i + 10, 0, 0 + i + 10, height); // Горизонтальная линия сетки
                    graphics.DrawString(lx.ToString(), new Font("10_IC_1", 8, FontStyle.Bold), Brushes.Black, 0 + i + 5, height / 2 + 5); // подписи меток
                }
                graphics.DrawLine(new Pen(Color.Black, 2), 0 + i + 10, height / 2 - 5, 0 + i + 10, height / 2 + 5); // метка на оси OX

                ++lx;
            }

            int ly = height / 40 - 1;
            for (int i = 20; i < height; i += 20)
            {
                if (ly != 0)
                {
                    graphics.DrawLine(new Pen(Color.Gray, 1), 0, 0 + i, width, 0 + i); // Вертикальная линия сетки
                    graphics.DrawString(ly.ToString(), new Font("10_IC_1", 8, FontStyle.Bold), Brushes.Black, width / 2 + 5, 0 + i - 5); // подписи меток
                }
                graphics.DrawLine(new Pen(Color.Black, 2), width / 2 - 5, 0 + i, width / 2 + 5, 0 + i); // метка на оси OY

                --ly;
            }
        }
    }
}
