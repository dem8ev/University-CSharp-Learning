using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_week_plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.Write("Введите номер дня недели (1-7) = ");
            day = Int32.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник: утренний штурм математики и C#");
                    break;
                case 2:
                    Console.WriteLine("Вторник: тренажерный зал");
                    break;
                case 3:
                    Console.WriteLine("Среда: днейвное изучение лекций по C#");
                    break;
                case 4:
                    Console.WriteLine("Четверг: прогулка в парке, плотный ужин");
                    break;
                case 5:
                    Console.WriteLine("Пятница: утренний тихий завтрак");
                    break;
                case 6:
                    Console.WriteLine("Суббота: восстанавилваем колени дома");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье: идеальный обед, прогулка в парке");
                    break;
                default:
                    Console.WriteLine("Обычный продуктивный день семестра");
                    break;
            }
        }
    }
}
