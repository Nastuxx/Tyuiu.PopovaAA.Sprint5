using System.IO;
using Tyuiu.PopovaAA.Sprint5.Task7.V14.Lib;
namespace Tyuiu.PopovaAA.Sprint5.Task7.V14.Test
{
    [TestClass]
    public class DataService
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = $@"C:\Users\popov\source\repos\Tyuiu.PopovaAA.Sprint5\Tyuiu.PopovaAA.Sprint5.Task7.V14\bin\Debug\net8.0\InPutDataFileTask7V14.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExists);
        }
    }
}