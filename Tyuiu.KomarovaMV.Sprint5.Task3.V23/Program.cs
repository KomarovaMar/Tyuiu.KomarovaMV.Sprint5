using System.IO;
using Tyuiu.KomarovaMV.Sprint5.Task3.V23.Lib;
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
        Console.WriteLine("*Дано выражение, вычислить его значение при x = 3, результат сохранить в     *");
        Console.WriteLine("*бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх   *");
        Console.WriteLine("*знаков после запятой.                                                       *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        int x = 3;
        Console.WriteLine("x="+x);
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        string path=ds.SaveToFileTextData(x);
        Console.WriteLine("Файл: "+path);
        Console.WriteLine("создан!");
        Console.ReadKey();
    }
}