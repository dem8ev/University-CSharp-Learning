//Использование пространства имен:
using System.Windows.Forms;
//Класс с главным методом программы:
class AnotherDialogDemo
{
    //Главный метод программы:
    static void Main()
    {
        //Отображение диалогового окна:
        MessageBox.Show("У вас не установлены все компоненты программы!", //Сообщение
            "Предупреждение",         //Название окна
            MessageBoxButtons.OK,       //Кнопки
            MessageBoxIcon.Warning  //Пиктограмма
            );
    }
}