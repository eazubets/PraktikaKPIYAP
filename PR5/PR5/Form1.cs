using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string decimalString = textBox1.Text; // получаем строку из TextBox

            int decimalNumber;
            if (!Int32.TryParse(decimalString, out decimalNumber)) // проверяем, что это действительно число
            {
                MessageBox.Show("Введите корректное целое число!"); // выводим сообщение об ошибке, если введена некорректная строка
                return;
            }

            string octalString = Convert.ToString(decimalNumber, 8); // конвертируем число в строку в восьмеричном формате

            textBox2.Text = octalString; // выводим результат в другой TextBox

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputString = textBox1.Text; // получаем строку из TextBox

            bool isPositiveInteger = true;

            // проверяем, что введенная строка состоит только из цифр
            foreach (char c in inputString)
            {
                if (!Char.IsDigit(c))
                {
                    isPositiveInteger = false;
                    break;
                }
            }

            // если строка состоит только из цифр, проверяем, что это положительное число
            if (isPositiveInteger)
            {
                int number = Int32.Parse(inputString);
                if (number <= 0)
                {
                    isPositiveInteger = false;
                }
            }

            if (isPositiveInteger)
            {
                MessageBox.Show("Введенная строка является правильной записью положительного целого числа в десятичной системе счисления.");
            }
            else
            {
                MessageBox.Show("Введенная строка не является правильной записью положительного целого числа в десятичной системе счисления.");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void InsertAfterKthOccurrence(string s, string s1, string s2, int k)
        {
            int index = -1;
            int count = 0;

            while (true)
            {
                index = s.IndexOf(s1, index + 1);

                if (index == -1)
                {
                    break;
                }

                count++;

                if (count == k)
                {
                    s = s.Insert(index + s1.Length, s2);
                }
            }

            MessageBox.Show(s);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            string s1 = textBox5.Text;
            string s2 = textBox6.Text;
            int k = int.Parse(textBox7.Text);

            InsertAfterKthOccurrence(s, s1, s2, k);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        private string RemoveShortestWord(string inputString)
        {
            // Разделение входной строки на слова по запятой и точке
            string[] words = inputString.Split(new char[] { ',', '.' });

            // Поиск самого короткого слова
            int shortestWordIndex = 0;
            int shortestWordLength = int.MaxValue;
            for (int i = 0; i < words.Length; i++)
            {
                int wordLength = words[i].Trim().Length;
                if (wordLength < shortestWordLength)
                {
                    shortestWordLength = wordLength;
                    shortestWordIndex = i;
                }
            }

            // Удаление самого короткого слова
            List<string> wordsList = words.ToList();
            wordsList.RemoveAt(shortestWordIndex);

            // Объединение слов в новую строку с запятыми и точкой
            string outputString = string.Join(", ", wordsList);
            outputString += ".";

            // Возвращение результата
            return outputString;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputString = textBox9.Text;
            string outputString = RemoveShortestWord(inputString);
            label10.Text = outputString;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
