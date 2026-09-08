using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_task2._2_variant4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long N, rest;   //long для тогго, чтобы пользователь смог ввести прям большое число
            Console.Write("Введите целое число N (N > 0): ");
            N = long.Parse(Console.ReadLine());
            do
            {
                rest = N % 10;
                N /= 10;
            }
            while (N > 0 && rest != 2);
            Console.WriteLine(rest == 2);
        }
    }
}
