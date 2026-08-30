using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int S, N;
            S = 0; N = 0;
            for (int i = 1; i <= 2; i++)
            {
                for (int k = 1; k <= 3; k++)
                {
                    S += i;
                }
                N += S;
            }
            Console.WriteLine("S = " + S);
            Console.WriteLine("N = " + N);
        }
    }
}
