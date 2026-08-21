using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mounth;
            Console.Write("Введите название месяца с заглавной буквы: ");
            mounth = Console.ReadLine();
            switch(mounth)
            {
                case "Январь":
                    Console.WriteLine("Это зима!");
                    break;
                case "Февраль":
                    Console.WriteLine("Это зима!");
                    break;
                case "Март":
                    Console.WriteLine("Это весна!");
                    break;
                case "Апрель":
                    Console.WriteLine("Это весна!");
                    break;
                case "Май":
                    Console.WriteLine("Это весна!");
                    break;
                case "Июнь":
                    Console.WriteLine("Это лето!");
                    break;
                case "Июль":
                    Console.WriteLine("Это лето!");
                    break;
                case "Август":
                    Console.WriteLine("Это лето!");
                    break;
                case "Сентябрь":
                    Console.WriteLine("Это осень!");
                    break;
                case "Октябрь":
                    Console.WriteLine("Это осень!");
                    break;
                case "Ноябрь":
                    Console.WriteLine("Это осень!");
                    break;
                case "Декабрь":
                    Console.WriteLine("Это зима!");
                    break;
                default:
                    Console.WriteLine("Вы ввели название месяца не правильно!");
                    break;
            }
        }
    }
}
