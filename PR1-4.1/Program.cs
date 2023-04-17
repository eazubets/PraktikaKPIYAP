using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод трех чисел
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            // Нахождение суммы двух наибольших чисел
            double sum = 0;
            if (num1 >= num2 && num1 >= num3)
            {
                sum = num1 + (num2 >= num3 ? num2 : num3);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                sum = num2 + (num1 >= num3 ? num1 : num3);
            }
            else
            {
                sum = num3 + (num1 >= num2 ? num1 : num2);
            }

            // Вывод результата на экран
            Console.WriteLine("Сумма двух наибольших чисел: " + sum);
        }
    }
}
