using Tyuiu.PopovaAA.Sprint5.Task5.V27.Lib;
using System.IO;
namespace Tyuiu.PopovaAA.Sprint5.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                 *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                            *");
            Console.WriteLine("* Задание #5                                                                *");
            Console.WriteLine("* Вариант #27                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан файл С:DataSprint5 InPutDataFileTask5V27.txt (файл взять из архива    *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и          *");
            Console.WriteLine("* cкопировать в неё файл) в котором есть набор значений. Найти среднее      *");
            Console.WriteLine("* значение всех целых чисел в файле, которые делятся на 5. Полученный       *");
            Console.WriteLine("* результат вывести на консоль. У вещеcтвенных значений округлить до трёх   *");
            Console.WriteLine("* знаков после запятой.                                                     *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V27.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Среднее значение целых чисел, которые делятся на 5 = " + res);
            Console.ReadKey();
        }
    }
}
