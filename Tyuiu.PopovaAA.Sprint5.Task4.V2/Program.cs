using Tyuiu.PopovaAA.Sprint5.Task4.V2.Lib;
namespace Tyuiu.PopovaAA.Sprint5.Task4.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                 *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                   *");
            Console.WriteLine("* Задание #4                                                                *");
            Console.WriteLine("* Вариант #2                                                                *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан файл С:DataSprint5 InPutDataFileTask4V0.txt (файл взять из архива     *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и          *");
            Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение. Прочитать   *");
            Console.WriteLine("* значение из файла и подставить вместо Х в формуле y = cos(x)+3x/0.25x+4-  *");
            Console.WriteLine("* 2.1x. Вычислить значение по формуле и результат округлить до трех знаков  *");
            Console.WriteLine("* после запятой.                                                            *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            string path = $@"{Path.GetTempPath()}\InPutDataFileTask4V0.txt";

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
