using Tyuiu.FabritsiusAO.Sprint4.Task4.V1.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #4 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9.                          *");
        Console.WriteLine("* Найдите сумму четных элементов массива.                                 *");
        Console.WriteLine("* 2, 5, 1, 7, 5,                                                          *");
        Console.WriteLine("* 4, 4, 7, 4, 4,                                                          *");
        Console.WriteLine("* 7, 1, 6, 8, 8,                                                          *");
        Console.WriteLine("* 8, 1, 5, 8, 4,                                                          *");
        Console.WriteLine("* 8, 9, 1, 7, 3                                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Введите количество строк в массиве:");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов в массиве:");
        int col = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write("Введите " + i + "," + j + " элемент массива:");
                array[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\nМассив:");
        for (int i = 0;i < row; i++)
        {
            for (int j = 0;j < col; j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(array);
        Console.WriteLine(res);
    }
}