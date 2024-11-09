using Tyuiu.KomarovaMV.Sprint5.Task3.V23.Lib;
namespace Tyuiu.KomarovaMV.Sprint5.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\PC\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo ra = new FileInfo(path);
            bool fileEx = ra.Exists;
            Assert.AreEqual(true, fileEx);
        }
    }
}