using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_task3._3._2_variant4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double BookValue, BuyersMoney, shortage, surplus;
            Console.WriteLine("Приветствуем в нашем магазине!");
            Console.Write("Введите стоимость выбранной книги (руб.): ");
            BookValue = double.Parse(Console.ReadLine());
            Console.Write("Введите сумму денег, которую вы внесли для покупки (руб.): ");
            BuyersMoney = double.Parse(Console.ReadLine());
            if (BuyersMoney < BookValue)
            {
                shortage = BookValue - BuyersMoney;
                Console.WriteLine($"Добавьте {shortage,5:#0.##} руб.");
            }
            else
                if (BuyersMoney > BookValue)
                {
                    surplus = BuyersMoney - BookValue;
                    Console.WriteLine($"Возьмите сдачу {surplus,5:#0.##} руб.");
                }
                else
                    Console.WriteLine("Спасибо");
        }
    }
}
