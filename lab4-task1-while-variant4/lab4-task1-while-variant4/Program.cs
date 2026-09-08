using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab4_task1_while_variant4
{
    internal class While
    {
        static void Main(string[] args)
        {
            int a;
            double y, x = 0.6, MaxInterval = 1.0, dx = 0.1;
            Console.Write("Введите натуральное число a = ");
            a = int.Parse(Console.ReadLine());
            while (x <= MaxInterval)
            {
                y = Math.Tan(x) * Math.Sqrt(1 + a * Math.Pow(x, 2));
                Console.WriteLine($"При значении x = {x:F1} y = {y:F3}");
                x += dx;
            }
        }
    }
}
