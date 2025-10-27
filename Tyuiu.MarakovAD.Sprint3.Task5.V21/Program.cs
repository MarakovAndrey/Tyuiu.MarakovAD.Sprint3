using Tyuiu.MarakovAD.Sprint3.Task5.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Мараков А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c циклами                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Мараков Андрей Дмитриевич | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл for решить уравнение");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите начальное значение 1: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите начальное значение 2: ");
        int z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите конечное значение 1: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите конечное значение 2: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.GetSumSumSeries(x, y,z,a,b);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}