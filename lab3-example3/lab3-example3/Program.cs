using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Найти сумму и произведение N чисел, введенных
            // пользователем с клавиатуры.
            int A, S, P, N;
            Console.Write("Введите количество чисел, N = ");
            N = int.Parse(Console.ReadLine());
            S = 0; P = 1;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Введите " + i + " целое число: ");
                A = int.Parse(Console.ReadLine());
                S += A;
                P *= A;
            }
            Console.WriteLine("Сумма всех введенных " + N + " чисел равна " + S + ";\nПроизведение всех " + N + " чисел равно " + P + ".");
        }
    }
}
