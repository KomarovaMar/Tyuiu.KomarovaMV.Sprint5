using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.KomarovaMV.Sprint5.Task3.V23.Lib
{
    public class DataService : ISprint5Task3V23
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath() , "OutPutFileTask3.bin" });
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists) { File.Delete(path); }
            double z = Math.Round((1 + Math.Pow((double)x, 3) / Math.Pow((double)x, 2)),3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
