using Tyuiu.FabritsiusAO.Sprint4.Task3.V12.Lib;
namespace Tyuiu.FabritsiusAO.Sprint4.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();




            int[,] restest = { { 1, 7, 4, 9, 7 }, { 1, 1, 5, 1, 6 }, { 1, 3, 3, 1, 7 }, { 8, 4, 2, 4, 5 }, { 8, 8, 9, 1, 6 } };
            int res = ds.Calculate(restest);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}