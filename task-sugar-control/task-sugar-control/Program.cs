using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_sugar_control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите количество ложек сахара, добавленных в чай a = ");
            a = Int32.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Отлично! Вы супер, жирок на боках уходит эффективнее =)"); 
            }
            else
            {
                Console.WriteLine("Внимание, произошел выброс инсулина. Постарайтесь на прогулке идти быстрее!");
            }
        }
    }
}
