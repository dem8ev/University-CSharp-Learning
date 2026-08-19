using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Действительные переменные:
            double a, x, y;
            //Считывание действительных чисел:
            Console.Write("Введите действительное число x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите действительное число y: ");
            a = double.Parse(Console.ReadLine());
            //Вычисляем значение переменной y:
            if ((x >= 1) & (x <= 2))
            {
                y = Math.Tan(x);
            }
            else
            {
                if (x > 2)
                {
                    y = Math.Pow(a, x);
                }
                else
                {
                    y = x;
                }
            }
            Console.WriteLine("y = {0,5:#0.###}", y);
        }
    }
}
