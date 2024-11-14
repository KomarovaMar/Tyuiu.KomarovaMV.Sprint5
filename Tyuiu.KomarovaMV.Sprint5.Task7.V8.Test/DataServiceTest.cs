using Tyuiu.KomarovaMV.Sprint5.Task7.V8.Lib;
namespace Tyuiu.KomarovaMV.Sprint5.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\PC\AppData\Local\Temp\OutPutDataFileTask7V8.txt";
            FileInfo file = new FileInfo(path);
            bool a=file.Exists;
            Assert.AreEqual(true, a);
        }
    }
}