using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KomarovaMV.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();
            FileInfo fileinfo = new FileInfo(path);
            if (fileinfo.Exists ) { File.Delete(path); }
            double z;
            string sz;
            for (int x=startValue; x <= stopValue; x++)
            {
                z = Math.Round((Math.Sin(x)/(x+1.7)-Math.Cos(x)*4*x-6),2);
                if (1.7+x==0) { z = 0; }
                sz = Convert.ToString(z);
                if (x != stopValue)
                {
                    File.AppendAllText(path, sz + Environment.NewLine);
                }
                else { File.AppendAllText(path, sz); }
            }
            return path;
        }
    }
}
