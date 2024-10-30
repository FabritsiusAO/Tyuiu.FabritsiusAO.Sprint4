using Tyuiu.FabritsiusAO.Sprint4.Task1.V9.Lib;
namespace Tyuiu.FabritsiusAO.Sprint4.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int res = ds.Calculate(array);
            int wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}