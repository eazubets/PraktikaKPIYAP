using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2_1
{
    public partial class Form1 : Form
    {
        double x;
        bool ftx;
        double y;
        bool fty;
        double z;
        bool ftz;
        double result;
        double h;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Лабораторная работа 23";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!double.TryParse(textBox1.Text, out x))
            { 
                MessageBox.Show("No valid content x");
            }
            else
            {
            ftx = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("No valid content y");
            }
            else
            {
            fty = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out z))  
            {
                MessageBox.Show("No valid content z");
            }
            else
            {
            ftz = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ftx && fty && ftz)
            { 
                ftx=false;
                fty=false;
                ftz=false;
                textBox4.Text = (((Math.Pow(x, y + 1) + Math.Exp(y - 1)) / (1 + x * Math.Abs(y - Math.Tan(z))))
                           * (1 + Math.Abs(y - x))
                           + (Math.Pow(Math.Abs(y - x), 2) / 2)
                           - (Math.Pow(Math.Abs(y - x), 3) / 3)).ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
