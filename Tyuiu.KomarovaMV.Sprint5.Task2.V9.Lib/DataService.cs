using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KomarovaMV.Sprint5.Task2.V9.Lib
{
    public class DataService : ISprint5Task2V9
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists) {File.Delete(path); }
            int rows = matrix.GetUpperBound(0) + 1;
            int cols=matrix.Length/rows;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0) { matrix[i, j] = 0; }
                }
                for (int x = 0; x < rows; x++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (j != cols - 1) { str += matrix[i, j] + ";"; }
                        else { str += matrix[i, j]; }

                    }
                    if (x != rows - 1) { File.AppendAllText(path, str + Environment.NewLine); }
                    else { File.AppendAllText(path, str); }
                }
                str = "";
            }
            
            
            return path;
        }
    }
}
