using System.IO;
using Tyuiu.PopovaAA.Sprint5.Task4.V2.Lib;
namespace Tyuiu.PopovaAA.Sprint5.Task4.V2.Test
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