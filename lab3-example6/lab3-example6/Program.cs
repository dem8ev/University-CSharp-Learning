using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_example6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P, S;
            P = 1;  // начальное значение произведения
            // Цикл накапливания произведения:
            for (int x = 1; x <= 3; x++)
            {
                S = 0;  // начальное значение суммы
                for (int y = 2; y <= 5; y++)
                    S += (double)x / y; // накапливание суммы
                P *= S; // накапливание произведения
            }
            Console.WriteLine("P = {0,6:##.###}", P);
        }
    }
}
