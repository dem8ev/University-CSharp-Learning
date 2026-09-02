using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B;
            Console.Write("Введите длину отрезка A = ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Введите длину отрезка B (B < A) = ");
            B = double.Parse(Console.ReadLine());
            while (A >= B)
                A -= B;
            Console.WriteLine($"Длина незанятой части отрезка A = {A}.");
        }
    }
}
