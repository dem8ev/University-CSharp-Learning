using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость 1 кг. конфет, руб. = ");
            double price = double.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Стоимость {i} кг. конфет = {i * price} руб.");
            }
        }
    }
}
