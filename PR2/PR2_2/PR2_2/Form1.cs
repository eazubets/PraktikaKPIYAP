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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR2_2
{
    public partial class Form1 : Form
    {
        double a;
        bool fta;
        double b;
        bool ftb;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("No valid content x");
            }
            else
            {
                fta = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fta && ftb )
            {
                fta = false;
                ftb = false;
                textBox3.Text ="Произвидение котангнса частного корень суммы е и частного суммы а и 4.8 и разности b и квадрата а и корня суммы а и квадрата косинуса суммы а и b и е в степени часного синуса а и косинуса b " + (1 / Math.Tan(Math.Sqrt(Math.Exp(1) + (a + 4.8) / (a + Math.Pow(Math.Cos(a + b), 2))) / Math.Sqrt(a + Math.Pow(Math.Cos(a + b), 2))) * Math.Exp(Math.Sin(a) / Math.Cos(b))).ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("No valid content y");
            }
            else
            {
                ftb = true;
            }
        }
    }
    }

