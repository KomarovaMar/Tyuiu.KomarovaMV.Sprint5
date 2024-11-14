using Tyuiu.KomarovaMV.Sprint5.Task7.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#5                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #7                                                                 *");
        Console.WriteLine("* Вариант #8                                                                 *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Найти количество знаков вопроса в заданной строке.                          *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        string path = @"C:\DataSprint5\InPutDataFileTask7V8.txt";
        Console.WriteLine(path);
        Console.WriteLine("*                                                                            *");
        string min = ds.LoadDataAndSave(path);
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine(min);
        Console.ReadKey();
    }
}