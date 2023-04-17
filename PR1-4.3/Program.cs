using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N (> 0): ");
            int N = Convert.ToInt32(Console.ReadLine()); // Ввод значения N

            double sum = 0; // Инициализация переменной для суммы

            for (int i = 1; i <= N; i++)
            {
                double factorial = 1; // Инициализация переменной для факториала

                for (int j = 1; j <= i; j++)
                {
                    factorial *= j; // Вычисление факториала числа i
                }

                sum += factorial; // Добавление факториала к сумме
            }

            // Вывод результата на экран
            Console.WriteLine("Сумма факториалов чисел от 1 до " + N + " равна: " + sum);
        }
    }
}
