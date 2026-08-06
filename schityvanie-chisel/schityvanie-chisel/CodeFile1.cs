using System;
class EnterInteger
{
    static void Main()
    {
        //Переменные
        int a, b, year = 2026;
        //Ввод данных:
        Console.Write("В каком году вы родились? ");
        a = Int32.Parse(Console.ReadLine());
        //Решение:
        b = year - a;
        //Вывод данных:
        Console.Write("Вам " + b + "!");
    }
}