using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FabritsiusAO.Sprint4.Task6.V8.Lib
{
    public class DataService : ISprint4Task6V8
    {
        public string[] Calculate(string[] array)
        {
            string[] array1 = Array.FindAll(array, x => x.Length > 4);
            return array1;
        }
    }
}
