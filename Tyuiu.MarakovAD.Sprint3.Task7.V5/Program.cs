using Tyuiu.MarakovAD.Sprint3.Task7.V5.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Мараков А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c циклами                                   *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Мараков Андрей Дмитриевич | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        int len = ds.GetMassFunction(x, y).Length;
        double[] valueArray;
        valueArray = new double[len];
        valueArray = ds.GetMassFunction(x, y);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+--------+--------+");
        Console.WriteLine("|   x    +   f    |");
        Console.WriteLine("+--------+--------+");
        for (int i = 0; i <= len - 1; i++) {
            Console.WriteLine("|{0,5:d}    |   {1, 5:f2}    |", x, valueArray[i]);
            x++;
        }
        Console.WriteLine("+--------+--------+");
        Console.ReadKey();
    }
}