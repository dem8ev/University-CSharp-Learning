using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int count;
            Console.Write("Введите уелое число N > 0, N = ");
            N = int.Parse(Console.ReadLine());
            count = 0;
            while (N != 0)
            {
                N = N / 10;
                count += 1;
            }
            Console.WriteLine($"Количество чисел в указанном числе = {count}.");
        }
    }
}
