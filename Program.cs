using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод числа K
            Console.WriteLine("Введите число K (от 1 до 365):");
            int k = Convert.ToInt32(Console.ReadLine());

            // Определение дня недели
            int dayOfWeek = (k + 2) % 7; // 1 января было средой, поэтому прибавляем 2 к K

            // Вывод результата
            Console.WriteLine("Номер дня недели для K-го дня года: " + dayOfWeek);
        }
    }
}
