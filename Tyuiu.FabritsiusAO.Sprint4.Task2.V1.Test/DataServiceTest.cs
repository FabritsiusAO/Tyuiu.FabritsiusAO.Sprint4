using Tyuiu.FabritsiusAO.Sprint4.Task2.V1.Lib;
namespace Tyuiu.FabritsiusAO.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[] array = { 1, 2, 3, 4, 5 };
            int res = ds.Calculate(array);
            int wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}