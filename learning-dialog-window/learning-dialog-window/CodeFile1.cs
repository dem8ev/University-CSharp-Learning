//Использование ресурсов Visual Basic:
using Microsoft.VisualBasic;
using System.Windows.Forms;
class InputDialogDemo
{
    //Главный метод программы:
    static void Main()
    {
        //Текстовая переменная:
        string name;
        //Отображение окна с полем ввода:
        name = Interaction.InputBox(
            "Как вас зовут?",       //Текст над полем ввода
            "Давайте знакомиться!"  //Название окна
            );
        //Еще одна текстовая переменная:
        string txt = "Очень приятно," + name + "!";
        //Окно с сообщением:
        MessageBox.Show(txt, "Знакомство состоялось!");
    }
}