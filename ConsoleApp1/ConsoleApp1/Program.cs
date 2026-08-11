using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Объявление переменных
            double x, y, z, a, b;
            //Ввод данных (иницциализация переменных)
            Console.Write("Введите x = ");  //вывод сообщения на экран
            x = double.Parse(Console.ReadLine());  //ввод значения переменной с клавиатуры
            Console.Write("Введите y = ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Введите z = ");
            z = double.Parse(Console.ReadLine());
            //Реализация вычислений
            a = Math.Cos(y - 3);
            b = Math.Abs(x - y) * (1 + Math.Sin(z) / (x + y));
            //Вывод значений
            Console.WriteLine($"a = {a,5:#0.##}");
            Console.Write($"b = {b,5:#0.##}");
        }
    }
}
