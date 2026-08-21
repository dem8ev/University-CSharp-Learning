using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_task3._1_variant4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, x1, y1, x2, y2;
            Console.WriteLine("Давайте обозначим две точки A и C, с помощью которых мы построим прямоугольник ABCD на координатной плоскости,\nстороны которого параллельны координатным осям!");
            Console.Write("Указываем левую верхнюю вершину прямоугольника (A): введите координату x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Указываем левую верхнюю вершину прямоугольника (A): введите координату y1: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Указываем правую нижнюю вершину прямоугольника (C): введите координату x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Указываем правую нижнюю вершину прямоугольника (C): введите координату y2: ");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Давайте обозначим точку \"E\" и проверим, будет ли она лежать внутри нашего прямоугольника ABCD!");
            Console.Write("Указываем первую координату точки x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Указываем вторую координату точки y: ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine(x >= x1 && x <= x2 && y >= y2 && y <= y1 ? $"Точка \"E\" с координатами ({x}, {y}) лежит внутри прямоугольника ABCD." : $"Точка с координатами ({x}, {y}) НЕ лежит внутри прямоугольника ABCD.");
        }
    }
}
