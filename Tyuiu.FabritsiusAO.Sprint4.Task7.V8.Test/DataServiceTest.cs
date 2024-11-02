using Tyuiu.FabritsiusAO.Sprint4.Task7.V8.Lib;
namespace Tyuiu.FabritsiusAO.Sprint4.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int n = 2;
            int m = 2;
            string value = "1111";
            int wait = 4;
            int res = ds.Calculate(n, m, value);
            Assert.AreEqual(wait, res);
        }
    }
}