using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FabritsiusAO.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] array)
        {
            int row = array.GetUpperBound(0) + 1;
            int col = array.Length / row;
            int res = 10;
            for (int i = 0; i < row; i++)
                for (int j = 2; j < col - 2; j++)
                    if (array[i, j] < res)
                        res = array[i, j];
            return res;
        }
    }
}
