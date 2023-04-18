using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace PR2_3
{
    public partial class Form1 : Form
    {
        double b = 0.001; // Значение b
        bool ftx1;
        double x1 = 2; // Значение x1
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ftx1)
            {
                ftx1 = false;
                textBox4.Text = CalculateF(x1, b).ToString();
            }
            else
            {
                MessageBox.Show("No valid content");
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private double CalculateF(double x, double b)
        {
            double sum = 0;
            double term = 0;
            double pre;
            int n = 1;
            double factor = 1;

            do
            {
                pre = term;
                term = factor * (1 / ((2 * n - 1) * Math.Pow(x, 2 * n -1)));
                sum += term;
                n++;
                factor *= -1;
            } while (Math.Abs(term-pre) >= b);

            return 2 * sum;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out x1))
            {
                MessageBox.Show("No valid content z");
            }
            else
            {
                ftx1 = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
