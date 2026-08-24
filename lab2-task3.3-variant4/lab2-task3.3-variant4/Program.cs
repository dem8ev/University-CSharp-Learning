using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_task3._3_variant4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, n;
            Console.WriteLine("Из трех заданных целых чисел вывести те, что не превосходят заданного n>0\nи кратны 5.");
            Console.Write("Введите целое число a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите целое число b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите целое число c = ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Введите заданное целое число n>0; n = ");
            n = int.Parse(Console.ReadLine());
            if (a <= n && a % 5 == 0)
                Console.WriteLine(a);
            if (b <= n && b % 5 == 0)
                Console.WriteLine(b);
            if (c <= n && c % 5 == 0)
                Console.WriteLine(c);
            if (!(a <= n && a % 5 == 0) && !(b <= n && b % 5 == 0) && !(c <= n && c % 5 == 0))
                Console.WriteLine("Нет ни одного числа, удовлетворяющего начальным условиям.");
        }
    }
}
