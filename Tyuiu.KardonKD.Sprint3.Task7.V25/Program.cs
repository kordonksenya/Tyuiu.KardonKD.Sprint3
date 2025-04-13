using Tyuiu.KardonKD.Sprint3.Task7.V25.Lib;
namespace Tyuiu.KardonKD.Sprint3.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Кордон К.Д. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Кордон Ксения Дмитриевна | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, которая выводит таблицу знаяений функции:         *");
            Console.WriteLine("* F(x) = cos(x) + 4*x/2 - sin(x) * 3 * x (произвести табулирование)     *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага =  " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("+-------------+-------------+");
            Console.WriteLine("|      X      |     f(x)    |");
            Console.WriteLine("+-------------+-------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("| {0,6:d}      |   {1,6:f2}    |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+-------------+-------------+");
            Console.ReadKey();
        }
    }
}
