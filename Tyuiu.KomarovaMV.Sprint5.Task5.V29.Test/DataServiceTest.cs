using Tyuiu.KomarovaMV.Sprint5.Task5.V29.Lib;
namespace Tyuiu.KomarovaMV.Sprint5.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V29.txt";
            FileInfo ra = new FileInfo(path);
            bool fileEx = ra.Exists;
            Assert.AreEqual(true, fileEx);
        }
    }
}