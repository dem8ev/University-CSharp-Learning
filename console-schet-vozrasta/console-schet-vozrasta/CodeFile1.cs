using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
class WindowAge
{
    static void Main()
    {
        //Текстовые переменные:
        string res, txt;
        //Целочисленные переменные:
        int age, year = 2026, born;
        //Отображение окна с полем ввода:
        res = Interaction.InputBox("В каком году вы родились?", "Рассчет вашего возраста");
        //Преобразование текста в число:
        born = Int32.Parse(res);
        //Вычисление возраста:
        age = year - born;
        txt = "Тогда ваш возраст равен " + age;
        //Окно с сообщением:
        MessageBox.Show(txt, "А вот и ваш возраст!");
    }

}
