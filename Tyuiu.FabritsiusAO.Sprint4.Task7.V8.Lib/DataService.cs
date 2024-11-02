using System.Net.WebSockets;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FabritsiusAO.Sprint4.Task7.V8.Lib
{
    public class DataService : ISprint4Task7V8
    {
        public int Calculate(int n, int m, string value)
        {
            int res = 0;
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }    
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        res += array[i, j];
                    }
                }
            }
            return res;
        }
    }
}
