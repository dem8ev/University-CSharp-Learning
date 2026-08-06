using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
class ImyaVozrastWindow
{
    static void Main()
    {
        //Переменные:
        string name;    //Текстовая переменная для имени пользователя
        int age;        //Целочисленная переменная для возраста пользователя
        //Окно приветствия:
        MessageBox.Show("Благодарим за выбор нашего антивируса!",   //сообщение в окне
            "AntiVirus Secure",         //название окна
            MessageBoxButtons.OK,         //константа кнопки "ОК"
            MessageBoxIcon.Asterisk);  //константа пиктограммы i в синем круге
        //Окно с полем ввода:
        name = Interaction.InputBox("Укажите Ваше имя",    //текст в окне
            "Вход в учетную запись AntiVirus Secure");    //название окна + сразу считали значение из строки ввода в программу
        age = Int32.Parse(Interaction.InputBox("Укажите Ваш возраст (сколько Вам полных лет)", //текст в окне
            "Вход в учетную запись AntiVirus Secure"));   //название окна + сразу забрали данные и сделали их целочисленными
        //Конечное окно для сверки данных пользователя:
        MessageBox.Show("Ваше имя: " + name + ", Ваш возраст: " + age,  //текст в окне
            "Сверка данных учетной записи AntiVitusSecure");   //название окна
    }
}
