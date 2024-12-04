using Tyuiu.PopovaAA.Sprint5.Task6.V13.Lib;
namespace Tyuiu.PopovaAA.Sprint5.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                 *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                          *");
            Console.WriteLine("* Задание #6                                                                *");
            Console.WriteLine("* Вариант #13                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан файл С:DataSprint5 InPutDataFileTask5V27.txt (файл взять из архива    *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и          *");
            Console.WriteLine("* cкопировать в неё файл) в котором есть набор символьных данных. Найти     *");
            Console.WriteLine("* количество удвоенных букв сс в заданной строке.                           *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            string path = $@"C:\Users\popov\source\repos\Tyuiu.PopovaAA.Sprint5\Tyuiu.PopovaAA.Sprint5.Task6.V13\bin\Debug\net8.0\InPutDataFileTask6V13.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
