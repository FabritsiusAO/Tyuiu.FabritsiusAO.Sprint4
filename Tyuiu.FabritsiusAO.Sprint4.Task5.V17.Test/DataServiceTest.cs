using Tyuiu.FabritsiusAO.Sprint4.Task5.V17.Lib;
namespace Tyuiu.FabritsiusAO.Sprint4.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[,] array = { { -2, 2 }, { 2, 2 }, { -3, -1 }, { 0, 0 } };
            int res = ds.Calculate(array);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}