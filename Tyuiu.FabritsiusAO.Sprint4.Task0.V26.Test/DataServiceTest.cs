using Tyuiu.FabritsiusAO.Sprint4.Task0.V26.Lib;

namespace Tyuiu.FabritsiusAO.Sprint4.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[] array = [1, 2, 3, 4, 5];
            int res = ds.GetSumOddArrEl(array);
            int wait = 9;
            Assert.AreEqual(res, wait);

        }
    }
}