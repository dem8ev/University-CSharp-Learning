using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_task1_variant4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double A;
            Console.Write("Введите вещественное число A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Введите целое число N (N > 0): ");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{Math.Pow(A, i):#0.##}");
            }
        }
    }
}
