using System;
class ConsoleData
{
    static void Main()
    {
        string DayOfTheWeek, month;
        int date;
        Console.Title = "Напоминание";
        Console.WriteLine("Давайте выберем сегодняшнюю дату и установим напоминание!");
        Console.Write("Укажите день недели: ");
        DayOfTheWeek = Console.ReadLine();
        Console.Write("Укажите название месяца: ");
        month = Console.ReadLine();
        Console.Write("Укажите номер этого дня в месце: ");
        date = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Давайте убедимся, что данные введены верно:");
        Console.WriteLine("День недели: " + DayOfTheWeek + ";");
        Console.WriteLine("Название месяца: " + month + ";");
        Console.WriteLine("Номер дня в месяце: " + date + ";");
        Console.Write("Все верно?");
    }
}