using System.Numerics;
using Tyuiu.KomarovaMV.Sprint5.Task2.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#5                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #2                                                                 *");
        Console.WriteLine("* Вариант #9                                                                 *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Дано выражение вычислить его значение при x = 3, результат сохранить в      *");
        Console.WriteLine("*текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх  *");
        Console.WriteLine("*знаков после запятой.                                                       *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        int rows = 3;
        int cols = 3;
        int[,] matrix = new int[rows,cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Введите значение матрицы{i}{j}");
                matrix[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"{matrix[i,j]}\t");
            }
        }
        string path = ds.SaveToFileTextData(matrix);
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("Файл: "+path);
        Console.WriteLine("создан!");
        Console.ReadKey();
    }
}