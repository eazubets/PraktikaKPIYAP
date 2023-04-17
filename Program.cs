using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных
            Console.WriteLine("Введите скорость первого автомобиля (V1 км/ч):");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля (V2 км/ч):");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расстояние между автомобилями (S км):");
            double s = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время (T часов):");
            double t = Convert.ToDouble(Console.ReadLine());

            // Расчет общего пути и расстояния между автомобилями
            double totalSpeed = v1 + v2;
            double totalDistance = s + t * totalSpeed;

            // Вывод результата
            Console.WriteLine("Расстояние между автомобилями через " + t + " часов: " + totalDistance + " км");
        }
    }
}
