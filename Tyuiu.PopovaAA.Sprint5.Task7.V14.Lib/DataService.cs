using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PopovaAA.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V14.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }


            
            using (StreamReader reader = new StreamReader(path))
            {
                string strLine;
                while ((strLine = reader.ReadLine()) != null)
                {
                    strLine = strLine.ToUpper();

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    
                    
                }
            }
            return pathSaveFile;
        }
    }
}
