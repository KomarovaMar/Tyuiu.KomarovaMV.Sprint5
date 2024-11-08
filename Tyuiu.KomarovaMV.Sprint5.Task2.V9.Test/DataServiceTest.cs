using Tyuiu.KomarovaMV.Sprint5.Task2.V9.Lib;
namespace Tyuiu.KomarovaMV.Sprint5.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempPath();
            FileInfo ra = new FileInfo(path);
            bool fileEx = ra.Exists;
            Assert.AreEqual(true, fileEx);
        }
    }
}