using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.KomarovaMV.Sprint5.Task6.V26.Lib
{
    public class DataService : ISprint5Task6V26
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string str=File.ReadAllText(path);
            foreach (char c in str) { if (c == '?') { count++; } }
            return count;
        }
    }
}
