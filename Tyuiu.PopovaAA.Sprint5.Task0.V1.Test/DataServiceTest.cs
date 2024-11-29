using System.IO;
using Tyuiu.PopovaAA.Sprint5.Task0.V1.Lib;
namespace Tyuiu.PopovaAA.Sprint5.Task0.V1.Test
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