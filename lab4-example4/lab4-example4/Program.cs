using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, P;
            Console.Write("Целое число N (N > 0) = ");
            N = int.Parse(Console.ReadLine());
            P = 1;
            while (P < N)
                P *= 3;
            Console.WriteLine(N == P);
        }
    }
}
