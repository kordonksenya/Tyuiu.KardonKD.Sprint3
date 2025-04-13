using Tyuiu.KardonKD.Sprint3.Task4.V23.Lib;
namespace Tyuiu.KardonKD.Sprint3.Task4.V23
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Кордон Ксения Дмитриевна | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=(cos(x)/x)+3.При х = 0 прервать цикл.                         *");
            Console.WriteLine("*Полученные значения перемножать.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue, stopValue;
            Console.WriteLine("первое число = ");
            startValue = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("второе число = ");
            stopValue = Convert.ToInt16(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService DS = new DataService();
            Console.WriteLine("результат: " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
