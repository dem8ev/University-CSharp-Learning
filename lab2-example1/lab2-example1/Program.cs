using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Целочисленные переменные
            int number, reminder;
            //Символьная переменная
            string txt;
            Console.Write("Введите целое число: ");
            //Считывание целого числа:
            number = int.Parse(Console.ReadLine());
            //Вычисляем остаток от деления:
            reminder = number % 2;
            txt = (reminder == 0) ?"Введенное число четное!" : "Введенное число нечетное!";
            Console.WriteLine(txt);
        }
    }
}
