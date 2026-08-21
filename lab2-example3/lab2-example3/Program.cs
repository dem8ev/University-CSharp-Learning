using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Целочисленные переменные:
            int a, b, c, k;
            Console.Write("Введите целое число a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите целое число b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите целое число c: ");
            c = int.Parse(Console.ReadLine());
            k = 0;
            if (a > 0) { k++; }
            if (b > 0) { k++; }
            if (c > 0) { k++; }
            Console.WriteLine("Количество положительных чисел в исходном наборе = " + k);
        }
    }
}
