using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, x, y;
            Console.Write("Введите x = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите y = ");
            y = double.Parse(Console.ReadLine());
            a = (Math.Pow(2, y) + Math.Pow(3, x));  //в этом выражении можно убрать внешние скобки
            b = (Math.Abs(x) + (1 / (Math.Pow(y, 2) + 1)));
            //в этом выражении внтури кобок: (1 / (Math.Pow(y, 2)...); для компилятора C# число 1 - это
            //жесткий тип int. C# начнет делить целое 1 на целое число (например, 5), C# отбросит всю дробную
            //часть и этот кусок превратится в чистый ноль! Здесь работает и просто единица блоагодаря Math.Pow.
            //Math.Pow всегда возвращает дробное число типа double (5.0). Когда целое число (1) делится на дробное (5.0),
            //C# включает правило безопасности: переводит (1) в дробь (1.0).
            //Лучше указывать 1.0, так вычисления будут верны и без Math.Pow: (1.0 / (y * y) + 1)

            Console.WriteLine($"a = {a,5:#0.##}");
            Console.Write($"b = {b,5:#0.##}");
        }
    }
}
