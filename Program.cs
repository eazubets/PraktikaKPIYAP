using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод трехзначного числа
            Console.WriteLine("Введите трехзначное число:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Проверка, что число является трехзначным
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Введенное число не является трехзначным.");
                return;
            }

            // Получение цифр числа
            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int units = number % 10;

            // Перестановка цифр сотен и десятков
            int newNumber = tens * 100 + hundreds * 10 + units;

            // Вывод результата
            Console.WriteLine("Число после перестановки цифр сотен и десятков: " + newNumber);
        }
    }
}
