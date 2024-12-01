using Tyuiu.PopovaAA.Sprint5.Task1.V24.Lib;
namespace Tyuiu.PopovaAA.Sprint5.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                 *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                   *");
            Console.WriteLine("* Задание #1                                                                *");
            Console.WriteLine("* Вариант #24                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дана функция F(x)=3cos(x)/4x-0.5+sin(x)-5x-2 (произвести табулирование)   *");
            Console.WriteLine("* f(x) на заданном диапазоне [-5,5] с шагом 1. Произвести проверку деления  *");
            Console.WriteLine("* на 0. При делении на 0 вернуть значение 0.                                *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
