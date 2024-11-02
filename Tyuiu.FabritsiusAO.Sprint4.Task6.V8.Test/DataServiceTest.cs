using Tyuiu.FabritsiusAO.Sprint4.Task6.V8.Lib;
namespace Tyuiu.FabritsiusAO.Sprint4.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string[] test = { "1", "12", "123", "1234", "12345", "123456", "1234567" };
            string[] res = ds.Calculate(test);
            string[] wait = { "12345", "123456", "1234567" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}