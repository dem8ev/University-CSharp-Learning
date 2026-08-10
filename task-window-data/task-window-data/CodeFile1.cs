using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
class DateWindow
{
    static void Main()
    {
        string DayOfTheWeek, month;
        int date;
        MessageBox.Show("Давайте установим дату в Вашей ОС!", "Настройка Windows", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        DayOfTheWeek = Interaction.InputBox("Введие название сегодняшнего дня недели: ", "Настройка календаря Windows");
        month = Interaction.InputBox("Введите название сегодняшнего месяца: ", "Настройка календаря Windows");
        date = Int32.Parse(Interaction.InputBox("Укажите номер сегодняшнего дня в месяце: ", "Настройка календаря Windows"));
        MessageBox.Show("День недели: " + DayOfTheWeek + "; Название месяца: " + month + "; Номер дня в месяце: " + date + ".", "Завершение настройки Windows", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
    }
}