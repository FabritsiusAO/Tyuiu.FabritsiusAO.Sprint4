using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FabritsiusAO.Sprint4.Task4.V1.Lib
{
    public class DataService : ISprint4Task4V1
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;
            int row = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / row;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        res += matrix[i, j];
                    }
                }
            }
            return res;
        }
    }
}
