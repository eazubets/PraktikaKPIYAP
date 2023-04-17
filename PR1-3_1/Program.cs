using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Заданные значения переменных
            double x = 2.444;
            double y = 0.869 * Math.Pow(10, -2);
            double z = -0.13 * Math.Pow(10, 3);
            double h = -0.49871;

            // Решение уравнения
            double result = ((Math.Pow(x, y + 1) + Math.Exp(y - 1)) / (1 + x * Math.Abs(y - Math.Tan(z))))
                           * (1 + Math.Abs(y - x))
                           + (Math.Pow(Math.Abs(y - x), 2) / 2)
                           - (Math.Pow(Math.Abs(y - x), 3) / 3);

            // Вывод результата на экран
            Console.WriteLine("Результат решения уравнения: " + result);
        }
    }
}
