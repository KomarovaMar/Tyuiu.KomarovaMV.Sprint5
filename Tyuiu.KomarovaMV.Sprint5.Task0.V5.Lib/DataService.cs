using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KomarovaMV.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            double z = Math.Round(Math.Log((x+1)/(x+2)),3);
            File.WriteAllText(path,Convert.ToString(z));
            return path;
        }
    }
}
