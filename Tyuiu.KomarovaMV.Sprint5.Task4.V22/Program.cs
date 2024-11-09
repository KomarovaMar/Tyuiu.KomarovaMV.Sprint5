using Tyuiu.KomarovaMV.Sprint5.Task4.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#5                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #4                                                                 *");
        Console.WriteLine("* Вариант #22                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Прочитать значение из файла и подставить вместо Х в формуле .               *");
        Console.WriteLine("*Вычислить значение по формуле (Полученное значение округлить до трёх знаков *");
        Console.WriteLine("*после запятой) и вернуть полученный результат на консоль.                   *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        string path = @"C:\DataSprint5\InPutDataFileTask4V22.txt";
        double res=ds.LoadFromDataFile(path);
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}