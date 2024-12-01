using Tyuiu.PopovaAA.Sprint5.Task2.V30.Lib;
using System.IO;
namespace Tyuiu.PopovaAA.Sprint5.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.GetTempFileName();
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExists);
        }
    }
}