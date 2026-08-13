    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace lab1_task6._1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                double A, B, C,
                    SRectangle, //площадь прямоугольника размера A * B
                    SSquare,    //площадь квадрата со стороной C
                    SFreePartOfRectangle;   //площаль незанятой части прямоугольника квадратами
                int NumberOfSquares;    //количество квадратов, размещенных на прямоугольнике
                Console.WriteLine("Даны положительные числа A, B, C. На прямоугольнике размера AxB размещено максимально возможное количество квадратов со стороной C (без наложений). Найти количество квадратов, размещенных на прямоугольнике, а также площадь незанятой части прямоугольника");
                Console.Write("Введите A = ");
                A = double.Parse(Console.ReadLine());
                Console.Write("Ввелите B = ");
                B = double.Parse(Console.ReadLine());
                Console.Write("Введите C = ");
                C = double.Parse(Console.ReadLine());
                SRectangle = A * B;
                SSquare = Math.Pow(C, 2);
                NumberOfSquares = (int)((A / C) * (int)(B / C));
            //в строчке №27 возникли трудности:
            // сначала она выглядела так: NumberOfSquares = (A / C) * (B / C);
            //выдавало ошибку, что результат дробный (double) нельзя присвоить переменной int (NumberOfSquares).
            //Пытался так: NumberOfSquares = int.Parse((A / C) * (B / C)); и даже так: int NumberOfSquares = (A / C) * (B / C);
            //ничего не помогало.
            //ИИ подсказал: чтобы отбросить дробную часть и превратить double в int, используют операцию ЯВНОГО ПРИВЕДЕНИЯ ТИПОВ
            // (int) перед переменной.
            //Попробовал так: NumberOfSquares = (int)((A / C) * (B / C));
            //но это тоже не верно, т.к. круглые скобки заставляют компьютер сначала ПЕРЕМНОЖИТЬ ДРОБНЫЕ РЕЗУЛЬТАТЫ деления,
            //а уже потом округлить общий итог. Если оставить так, то считается количество квадратов (по форме) + оставшееся, незаполненное место,
            //куда бы мог войти еще один квадрат (например, букву "Г", но это явно не квадрат).
            //Поэтому явное приведение типов нужно приписать к каждому множителю.
            SFreePartOfRectangle = SRectangle - (SSquare * NumberOfSquares);
                Console.WriteLine("Ответ:");
                Console.WriteLine($"Количество квадратов со стороной C, размещенных на прямоугольнике размера AxB = {NumberOfSquares};");
                Console.WriteLine($"Площадь незанятой части прямоугольника размером AxB квадратами со стороной C = {SFreePartOfRectangle}.");
            }
        }
    }
