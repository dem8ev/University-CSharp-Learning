using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_slaide_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Объявление переменных
            int n, a, b, c, s, p;
            //Ввод данных:
            Console.Write("Введите n = ");
            n = Int32.Parse(Console.ReadLine());
            //Блок решения:
            a = n / 100; //Выделяем сотни
            c = n % 10; //Выделяем единицы
            b = (n / 10) % 10; //Выделяем десятки
            p = a * b * c;
            s = a + b + c;
            //Вывод данных:
            Console.WriteLine("Произведение цифр = {0}", p);
            Console.WriteLine("Сумма цифр = {0}", s);
        }
    }
}
