using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PopovaAA.Sprint5.Task0.V1.Lib
{
    public class DataService : ISprint5Task0V1
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            
            double y = (double)Math.Pow(x, 3) + ((double)2 * Math.Pow(x, 2)) + ((double)5 * x) + (double)4;
          
            y = Math.Round(y, 3);
            
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
