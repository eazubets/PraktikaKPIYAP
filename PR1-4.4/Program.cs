using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод чисел N и K
            Console.Write("Введите значение N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение K: ");
            int K = Convert.ToInt32(Console.ReadLine());

            int quotient = 0; // Частное
            int remainder = N; // Остаток

            // Нахождение частного и остатка с использованием только сложения и вычитания
            while (remainder >= K)
            {
                remainder -= K;
                quotient++;
            }

            // Вывод результатов на экран
            Console.WriteLine($"Частное от деления {N} на {K}: {quotient}");
            Console.WriteLine($"Остаток от деления {N} на {K}: {remainder}");
        }
    }
}
