﻿using Tyuiu.KardonKD.Sprint3.Task1.V4.Lib;
namespace Tyuiu.KardonKD.Sprint3.Task1.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Кордон К.Д. | ИСТНб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #3                                                             *");
            Console.WriteLine("* Тема: Оператор цикла while                                            *");
            Console.WriteLine("* Задание #1                                                            *");
            Console.WriteLine("* Варинат #4                                                            *");
            Console.WriteLine("* Выполнила: кордон Ксентя Дмитриевна | ИСТНб-24-1                      *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("StartValue = 1");
            Console.WriteLine("StopValue = 10");
            int a, b;
            a = 1;
            b = 10;
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.GetSumSeries(a, b));
            Console.ReadKey();
        }
    }
}
