using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_task3_variant4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumbersOfTerms = 5;
            double S, volume;
            S = 0;
            Console.WriteLine("Получение суммы чисел, удовлетворяющих условию задачи:\n\nВведите последовательно 5 действительных чисел a1, a2, ... a5:\n");
            for (int i = 1; i <= NumbersOfTerms; i++)
            {
                Console.Write($"Введите {i}-е действительное число: ");
                volume = double.Parse(Console.ReadLine());
                if (Math.Abs(volume) < Math.Pow(i, 2))
                {
                    S += volume;
                }
            }
            Console.WriteLine($"Сумма всех действительных чисел, удовлетворяющих условию задачи = {S,5:##.##}");
        }
    }
}
