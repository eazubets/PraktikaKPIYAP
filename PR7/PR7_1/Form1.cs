using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR7_1
{
    public partial class Form1 : Form
    {
        struct Teacher
        {
            public string surname;
            public string exam;
            public DateTime date;
        }

        Teacher[] teachersArray = new Teacher[0];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void UpdateTable()
        {
            // очищаем таблицу
            dataGridView1.Rows.Clear();
            for (int i = 0; i < teachersArray.Length; i++)
            {
                dataGridView1.Rows.Add(new object[] { teachersArray[i].surname, teachersArray[i].exam, teachersArray[i].date });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string surname = textBox1.Text;
            DateTime date = dateTimePicker1.Value;
            for (int i = 0; i < teachersArray.Length; i++)
            {
                if (teachersArray[i].surname == surname && teachersArray[i].date == date)
                {
                    for (int j = i; j < teachersArray.Length - 1; j++)
                    {
                        teachersArray[j] = teachersArray[j + 1];
                    }
                    Array.Resize(ref teachersArray, teachersArray.Length - 1);
                    UpdateTable();
                    return;
                }
            }
            MessageBox.Show("Запись не найдена");
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            string surname = textBox1.Text;
            DateTime date = dateTimePicker1.Value;
            bool found = false;
            for (int i = 0; i < teachersArray.Length; i++)
            {
                if (teachersArray[i].surname == surname && teachersArray[i].date == date)
                {
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Запись не найдена");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // создаем новый экземпляр структуры Teacher и заполняем его данными
                Teacher teacher = new Teacher();
                teacher.surname = textBox1.Text;
                teacher.exam = textBox2.Text;
                teacher.date = dateTimePicker1.Value;

                // увеличиваем размер массива и добавляем в него новую структуру
                Array.Resize(ref teachersArray, teachersArray.Length + 1);
                teachersArray[teachersArray.Length - 1] = teacher;

                // очищаем текстовые поля и обновляем таблицу
                textBox1.Text = "";
                textBox2.Text = "";
                dateTimePicker1.Value = DateTime.Today;
                UpdateTable();
        }
    }
}
