using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два целах числа A и B (A < B).
            // Найти сумму всех целых чисел от A до B включительно.
            int A, B, S;
            Console.Write("Введите A = ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите B = ");
            B = int.Parse(Console.ReadLine());
            S = 0;      // Сумму нужно занулить предед циклом, чтобы внутри цикла переменная суммы (S) не осталась не заданной
            for (int i = A; i <= B; i++)
            {
                S += i;
            }
            Console.Write("Сумма всех целых чисел от A до B включительно = " + S);
        }
    }
}
