using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_task3._4_variant4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MassUnitNumber, InformationVolumeInTheseUnits;
            double MessageSizeInKilobytes;  //Переменная double для того, чтобы вместить все возможные значения из case 1 (Гб) и сохранить дробную часть. Типа int может просто не хватить для гигабайтов (например, 300 Гб)
            Console.Write("Введите номер единицы массы от 1 до 5, где:\n№1 - гигабайт;\n№2 - мегабайт;\n№3 - килобайт;\n№4 - байт;\n№5 - бит.\nНомер единицы массы: ");
            MassUnitNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите информационный объем в этих единицах (целое число): ");
            InformationVolumeInTheseUnits = int.Parse(Console.ReadLine());
            switch (MassUnitNumber)
            {
                case 1:
                    MessageSizeInKilobytes = InformationVolumeInTheseUnits * Math.Pow(1024, 2);
                    Console.WriteLine($"Объем данного сообщения в килобайтах = {MessageSizeInKilobytes,5:#0.#####} килобайт.");
                    break;
                case 2:
                    MessageSizeInKilobytes = InformationVolumeInTheseUnits * 1024;
                    Console.WriteLine($"Объем данного сообщения в килобайтах = {MessageSizeInKilobytes,5:#0.#####} килобайт.");
                    break;
                case 3:
                    MessageSizeInKilobytes = InformationVolumeInTheseUnits;
                    Console.WriteLine($"Объем данного сообщения в килобайтах = {MessageSizeInKilobytes,5:#0.#####} килобайт.");
                    break;
                case 4:
                    MessageSizeInKilobytes = InformationVolumeInTheseUnits / 1024.0;
                    Console.WriteLine($"Объем данного сообщения в килобайтах = {MessageSizeInKilobytes,5:#0.#####} килобайт.");
                    break;
                case 5:
                    MessageSizeInKilobytes = InformationVolumeInTheseUnits / 8.0 / 1024.0;  // Либо можно записать так: MessageSizeInKilobytes = InformationVolumeInTheseUnits / 8192.0; (Сразу перемножить знаменталеи 8 и 1024)
                    Console.WriteLine($"Объем данного сообщения в килобайтах = {MessageSizeInKilobytes,5:#0.#####} килобайт.");
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильный номер единицы массы!");
                    break;
            }
        }
    }
}
