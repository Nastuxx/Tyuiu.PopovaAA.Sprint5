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
            string path = $@"C:\DataSprint5\InPutDataFileTask5V27.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExists);
        }
    }
}