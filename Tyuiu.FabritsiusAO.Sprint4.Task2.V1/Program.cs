using Tyuiu.FabritsiusAO.Sprint4.Task2.V1.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #4 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
        Console.WriteLine("* случайными в диапазоне от 1 до 9 подсчитать произведение                *");
        Console.WriteLine("* четных элементов массива.                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Random rnd = new();
        Console.Write("Введите количество элементов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            array[i] = rnd.Next(1, 9);
        }
        Console.Write("Массив: ");
        for (int i = 0; i < len; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(array);
        Console.WriteLine(res);
    }
}