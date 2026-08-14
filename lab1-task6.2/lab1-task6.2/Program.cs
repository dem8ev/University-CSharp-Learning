using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, minute = 60,
                MinutesPassed,  //минут прошло
                MinutesElapsedInSeconds,    //минут прошло в секундах
                SecondsBeginningOfTheLastMinute;    //секунд прошло с последней минуты
            Console.WriteLine("С начала суток прошло N секунд (N - целое). Найти количество секунд, прошедших с начала последней минуты.");
            Console.Write("Введите количество секунд, прошедших с начала суток (целое число) N = ");
            N = int.Parse(Console.ReadLine());
            MinutesPassed = N / minute;
            MinutesElapsedInSeconds = MinutesPassed * minute;
            SecondsBeginningOfTheLastMinute = N - MinutesElapsedInSeconds;
            //Строки с 20 - 22 можно объединить в одну так:
            //SecondsBeginningOfTheLastMinute = N % minute;
            //Либо без переменной minute:
            //SecondsBeginningOfTheLastMinute = N % 60;
            Console.WriteLine($"Количество секунд, прошедшее с начала последней минуты = {SecondsBeginningOfTheLastMinute} с.");
        }
    }
}
