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
            string path = $@"C:\DataSprint5\InPutDataFileTask7V14.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}