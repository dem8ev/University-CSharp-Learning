using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_task3._2_variant4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, b, y;
            Console.WriteLine("Давайте вычислим, чему будет равна переменная y!");
            Console.Write("Введите значение переменной x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной b: ");
            b = double.Parse(Console.ReadLine());
            if (x > 1.5)
                y = Math.Pow(Math.Tan(x), 2) - Math.Cos(x) + Math.Sin(x);
            else
                if (x < -1)
                    y = Math.Pow(x, 2) + (3 * Math.Pow(x, 3) / 4.0) + b;
                else
                    // Здесь не нужна строчка if (x >= -1 && x <= 1.5), ведь если число
                    // не болше 1.5 и не меньше -1, то оно гарантированно находится в третьем
                    // промежутке.
                    // Если оставить строчку if (x >= -1 && x <= 1.5), то получится структура
                    // if-else if-else if и компилятор не поймет, что три промежутка покрывают
                    // всю числовую прямую
                    y = Math.Sqrt(Math.Abs(Math.Cos(x)));
            Console.WriteLine($"Переменная y = {y,5:#0.##}.");
        }
    }
}
