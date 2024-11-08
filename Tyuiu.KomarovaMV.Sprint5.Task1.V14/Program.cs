using Tyuiu.KomarovaMV.Sprint5.Task1.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#5                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #0                                                                 *");
        Console.WriteLine("* Вариант #5                                                                 *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Дано выражение вычислить его значение при x = 3, результат сохранить в      *");
        Console.WriteLine("*текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх  *");
        Console.WriteLine("*знаков после запятой.                                                       *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("*начальный шаг=-5                                                            *");
        Console.WriteLine("*конечный шаг=-5                                                             *");
        int x = -5;
        int y = 5;
        string path = ds.SaveToFileTextData(x,y);
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("Файл: " + path);
        Console.WriteLine("создан!");
        Console.ReadKey();
    }
}