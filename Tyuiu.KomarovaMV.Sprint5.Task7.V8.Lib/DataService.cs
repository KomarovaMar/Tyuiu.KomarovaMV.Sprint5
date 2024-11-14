using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.KomarovaMV.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string safeFile =Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V8.txt" });
            FileInfo fileInfo = new FileInfo(safeFile);
            if (fileInfo.Exists ) {fileInfo.Delete();}
            string str = File.ReadAllText(path);
            string a = "";
            for (int i = 0;i<str.Length;i++)
            {
                
                if ((str[i] >='А') && (str[i] <='Я'))
                {
                    a = a + Char.ToLower(str[i]);
                    continue;
                }
                a += str[i];
            }
            return a;
        }
    }
}
