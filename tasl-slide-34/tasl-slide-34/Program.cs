using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasl_slide_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Объявление переменных
            int n, m, a, b;
            //Ввод данных:
            Console.Write("Введите n = ");
            n = Int32.Parse(Console.ReadLine());
            //Блок решения:
            a = n / 10; //Выделяем десятки
            b = n % 10; //Выделяем единицы
            m = b * 10 + a; //Единицы * 10 + десятки
            //Вывод данных:
            Console.WriteLine("Полученное число = " + m);
        }
    }
}
