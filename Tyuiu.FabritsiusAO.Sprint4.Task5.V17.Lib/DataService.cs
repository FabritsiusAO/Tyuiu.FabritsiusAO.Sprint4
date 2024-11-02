using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FabritsiusAO.Sprint4.Task5.V17.Lib
{
    public class DataService : ISprint4Task5V17
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;
            int row = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / row;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
