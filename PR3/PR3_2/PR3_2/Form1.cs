using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем координаты точки A
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            // Получаем координаты прямоугольников Q1 и Q2
            int q1x1 = int.Parse(textBox3.Text);
            int q1y1 = int.Parse(textBox4.Text);
            int q1x2 = int.Parse(textBox5.Text);
            int q1y2 = int.Parse(textBox6.Text);

            int q2x1 = int.Parse(textBox7.Text);
            int q2y1 = int.Parse(textBox8.Text);
            int q2x2 = int.Parse(textBox9.Text);
            int q2y2 = int.Parse(textBox10.Text);

            // Проверяем, принадлежит ли точка A прямоугольнику Q1
            bool inQ1 = (x >= q1x1 && x <= q1x2 && y >= q1y1 && y <= q1y2);

            // Проверяем, принадлежит ли точка A прямоугольнику Q2
            bool inQ2 = (x >= q2x1 && x <= q2x2 && y >= q2y1 && y <= q2y2);

            // Формируем сообщение о принадлежности точки A прямоугольникам
            string message;
            if (inQ1 && inQ2)
            {
                message = "Точка A принадлежит обоим прямоугольникам.";
            }
            else if (inQ1)
            {
                message = "Точка A принадлежит прямоугольнику Q1.";
            }
            else if (inQ2)
            {
                message = "Точка A принадлежит прямоугольнику Q2.";
            }
            else
            {
                message = "Точка A не принадлежит ни одному из прямоугольников.";
            }

            // Выводим сообщение на экран
            MessageBox.Show(message);
        }
    }
    }
