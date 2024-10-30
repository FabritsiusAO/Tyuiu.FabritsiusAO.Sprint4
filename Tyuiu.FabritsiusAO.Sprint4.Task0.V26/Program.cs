using Tyuiu.FabritsiusAO.Sprint4.Task0.V26.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();
        int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7};
        Console.Title = "Спринт #4 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму          *");
        Console.WriteLine("* нечетных элементов массива.  {9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.GetSumOddArrEl(array);
        Console.WriteLine(res);
    }
}