using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод координат вершин прямоугольника
            Console.WriteLine("Введите координаты вершины A (x1, y1):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты вершины B (x2, y2):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Нахождение длины, ширины, периметра и площади прямоугольника
            double length = Math.Abs(x2 - x1);
            double width = Math.Abs(y2 - y1);
            double perimeter = 2 * (length + width);
            double area = length * width;

            // Вывод результатов
            Console.WriteLine("Длина прямоугольника: " + length);
            Console.WriteLine("Ширина прямоугольника: " + width);
            Console.WriteLine("Периметр прямоугольника: " + perimeter);
            Console.WriteLine("Площадь прямоугольника: " + area);
        }
    }
}
