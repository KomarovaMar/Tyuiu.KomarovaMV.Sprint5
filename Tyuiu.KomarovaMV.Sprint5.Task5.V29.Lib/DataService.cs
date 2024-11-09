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
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace(".",",");
                    if (((9<Convert.ToDouble(line)) & (Convert.ToDouble(line)<100)) & (Convert.ToDouble(line) < min)) { min = Convert.ToDouble(line);}
                }
            }
            return Math.Round(min,3);
        }
    }
}
