using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.KomarovaMV.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            double min = 10000000000;
            string str=File.ReadAllText(path);
            str = str.Replace(".", ",");
            string[] s=str.Split(' ');
            foreach(string sr in s)
            {
                if (((9 < Convert.ToDouble(sr)) & (Convert.ToDouble(sr) < 100)) & (Convert.ToDouble(sr) < min)) { min = Convert.ToDouble(sr); }
            }
            return Math.Round(min,3);
        }
    }
}
