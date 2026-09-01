using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_task4_variant4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y;
            y = 0;
            for (int c = 2; c <= 4; c++)
            {
                for (int k = -1; k <= 1; k++)
                {
                    y += (int)Math.Pow(c * k, 2);
                }
            }
            Console.WriteLine($"Значение выражения из условия задачи: y = {y}");
        }
    }
}
