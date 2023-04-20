using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_1
{
    public partial class Form1 : Form
    {
        private int Gcd(int m, int n)
        {
            // если одно из чисел равно нулю, то НОД равен другому числу
            if (n == 0) return m;
            if (m == 0) return n;

            // иначе применяем рекурсивный вызов алгоритма для пары (n, m mod n)
            return Gcd(n, m % n);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox1.Text); // считываем значение m из текстового поля
            int n = int.Parse(textBox2.Text); // считываем значение n из текстового поля

            int gcd = Gcd(m, n); // вычисляем НОД(m, n) с помощью функции Gcd

            MessageBox.Show("НОД(" + m + ", " + n + ") = " + gcd); // выводим результат в диалоговом окне
        }
    }
}
