using Tyuiu.PopovaAA.Sprint5.Task0.V1.Lib;
namespace Tyuiu.PopovaAA.Sprint5.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                 *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                          *");
            Console.WriteLine("* Задание #0                                                                *");
            Console.WriteLine("* Вариант #1                                                                *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дано выражение F(x)=x^3 + 2 * x^2 + 5 * x + 4. Вычислить его значение при *");
            Console.WriteLine("* x = 3, результат сохранить в текстовый файл OutPutFileTask0.txt и вывести *");
            Console.WriteLine("* на консоль. Округлить до трёх знаков после запятой.                       *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
