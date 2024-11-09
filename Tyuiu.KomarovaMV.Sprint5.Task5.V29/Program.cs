using Tyuiu.KomarovaMV.Sprint5.Task5.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#5                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #5                                                                 *");
        Console.WriteLine("* Вариант #29                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Найти минимальное целое число в файле, которое является двузначным числом.  *");
        Console.WriteLine("*Полученный результат вывести на консоль. У вещественных значений округлить  *");
        Console.WriteLine("*до трёх знаков после запятой.                                               *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        string path = @"C:\DataSprint5\InPutDataFileTask5V29.txt";
        double min=ds.LoadFromDataFile(path);
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine(min);
        Console.ReadKey();
    }
}