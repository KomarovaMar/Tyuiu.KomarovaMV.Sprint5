using Tyuiu.KomarovaMV.Sprint5.Task6.V26.Lib;
namespace Tyuiu.KomarovaMV.Sprint5.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V26.txt";
            FileInfo ra = new FileInfo(path);
            bool fileEx = ra.Exists;
            Assert.AreEqual(true, fileEx);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V26.txt";
            DataService ds = new DataService();
            int res=ds.LoadFromDataFile(path);
            Assert.AreEqual(6, res);
        }
    }
}