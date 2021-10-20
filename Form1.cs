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

        /*
             2.3.1 
             Случайным образом формируются координаты X и Y 100 точек. 
             Диапазон значений координат от -150 до +150. 
             Подсчитать и напечатать количество точек, расположенных на каждой четверти. 
             Отобразить результат работы программы с помощью таблицы (фрагмент) и графически, например, с помощью круговых диаграмм.
         */

        Graphics graphics;
        int width, height;
        // переменные количества точек
        int countPointsFirstQuater = 0;
        int countPointsSecondQuater = 0;
        int countPointsThirdQuater = 0;
        int countPointsFourthQuater = 0;

        void createChart()
        {
            graphics = pictureBox_chart.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);

            // Размеры области построения графика
            width = pictureBox_chart.Width;
            height = pictureBox_chart.Height;

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
            graphics.DrawString("X", new Font("10_IC_1", 12), Brushes.Black, width - 15, height / 2 + 10);            
        }

        private void button_createChart_Click(object sender, EventArgs e)
        {
            createChart();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            createChart();
            
            label1_count.Text = 0.ToString();
            label2_count.Text = 0.ToString();
            label3_count.Text = 0.ToString();
            label4_count.Text = 0.ToString();
            
            countPointsFirstQuater = 0;
            countPointsSecondQuater = 0;
            countPointsThirdQuater = 0;
            countPointsFourthQuater = 0;
        }

        private void button_createPoints_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // создание и заполнение массива точек
            Point[] points = new Point[100];
            for (int i = 0; i < points.Length; i++)
            {
                // points[i] = new Point(random.Next(-150, 151), random.Next(-150, 151));
                points[i] = new Point(random.Next(0, 301), random.Next(0, 301)); // 0 = -150, 301 = 150
            }            

            for (int i = 0; i < points.Length; i++)
            {
                // получение х и у  каждой точки массива
                int x = points[i].X;
                int y = points[i].Y;

                // отрисовка точек
                graphics.FillRectangle(Brushes.Red, x, y, 4, 4);

                /*if (y > 0 && x > 0) countPointsFirstQuater++;
                if(y > 0 && x < 0) countPointsSecondQuater++;
                if(y < 0 && x < 0) countPointsThirdQuater++;
                if(y < 0 && x > 0) countPointsFourthQuater++;*/

                // подсчёт количества точек в четвертях
                if (x > 150 && y < 150) countPointsFirstQuater++;
                if (x < 150 && y < 150) countPointsSecondQuater++;
                if (x < 150 && y > 150) countPointsThirdQuater++;
                if (x > 150 && y > 150) countPointsFourthQuater++;
            }

            // вывод количества точек в четвертях
            label1_count.Text = countPointsFirstQuater.ToString();
            label2_count.Text = countPointsSecondQuater.ToString();
            label3_count.Text = countPointsThirdQuater.ToString();
            label4_count.Text = countPointsFourthQuater.ToString();
        }
    }
}
