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




            int[,] restest = { { 9, 7, 4, 9, 7 }, { 5, 2, 5, 7, 6 }, { 8, 3, 3, 5, 7 }, { 8, 4, 2, 4, 5 }, { 8, 8, 9, 5, 6 } };
            int res = ds.Calculate(restest);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}