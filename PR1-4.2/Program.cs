using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        { // Ввод номера месяца
            Console.Write("Введите номер месяца (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            // Определение времени года на основе номера месяца
            string season;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "зима";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "весна";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "лето";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "осень";
                    break;
                default:
                    season = "некорректный номер месяца";
                    break;
            }

            // Вывод названия времени года на экран
            Console.WriteLine("Время года: " + season);
        }
    }
}
