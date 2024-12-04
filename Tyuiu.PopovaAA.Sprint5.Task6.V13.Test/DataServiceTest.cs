using System.IO;
using Tyuiu.PopovaAA.Sprint5.Task6.V13.Lib;
namespace Tyuiu.PopovaAA.Sprint5.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalk()
        {
            DataService ds = new DataService();
            string path = $@"C:\Users\popov\source\repos\Tyuiu.PopovaAA.Sprint5\Tyuiu.PopovaAA.Sprint5.Task6.V13\bin\Debug\net8.0\InPutDataFileTask6V13.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = $@"C:\Users\popov\source\repos\Tyuiu.PopovaAA.Sprint5\Tyuiu.PopovaAA.Sprint5.Task6.V13\bin\Debug\net8.0\InPutDataFileTask6V13.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExists);
        }
    }
}