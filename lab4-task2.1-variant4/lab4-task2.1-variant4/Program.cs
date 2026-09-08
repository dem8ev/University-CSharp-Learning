using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_task2._1_variant4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, Sum;
            int K;
            Console.Write("Введите число A (A > 1): ");
            A = double.Parse(Console.ReadLine());
            Sum = 1.0;
            K = 1;
            while (Sum <= A)
            {
                K++;
                Sum += 1.0 / K;
            }
            Console.WriteLine($"Наименьшее из целых чисел K = {K}, сама эта сумма = {Sum}");
        }
    }
}
