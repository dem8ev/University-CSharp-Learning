using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_task2_variant4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S, ArithmeticAverage;
            int N, NumbersOfTerms;
            Console.Write("Рассчет среднего арифметического отрицательных чисел:\n\nВведите количество действительных чисел N: ");
            N = int.Parse(Console.ReadLine());
            S = 0;
            NumbersOfTerms = 0;
            ArithmeticAverage = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Введите {i} действительное число: ");
                double volume = double.Parse(Console.ReadLine());
                if (volume < 0)
                {
                    S += volume;
                    NumbersOfTerms += 1;
                }
            }
            if (NumbersOfTerms > 0)
            {
                ArithmeticAverage = S / (double)NumbersOfTerms;
                Console.WriteLine($"Среднее арифметическое отрицательных чисел = {ArithmeticAverage,5:##.##}.");
            }
            else
                Console.WriteLine($"Вы ввели только положительные числа.");
        }
    }
}
