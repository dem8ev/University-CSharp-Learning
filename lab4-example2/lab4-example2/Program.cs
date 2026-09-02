using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, y, dx;
            Console.Write("Укажите начальное значение a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Укажите конечное значение b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Укажите значение шага табулирования dx = ");
            dx = double.Parse(Console.ReadLine());
            while (a <= b)
            {
                y = 1.0 / (a + 1);
                Console.WriteLine($"При значении x = {a:F2} y = {y:F3}");
                a += dx;
            }
        }
    }
}
