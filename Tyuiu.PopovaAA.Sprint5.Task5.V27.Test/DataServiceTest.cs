using System.IO;
using Tyuiu.PopovaAA.Sprint5.Task5.V27.Lib;
namespace Tyuiu.PopovaAA.Sprint5.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\popov\source\repos\Tyuiu.PopovaAA.Sprint5\Tyuiu.PopovaAA.Sprint5.Task5.V27\bin\Debug\net8.0\InPutDataFileTask5V27.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExists);
        }
    }
}