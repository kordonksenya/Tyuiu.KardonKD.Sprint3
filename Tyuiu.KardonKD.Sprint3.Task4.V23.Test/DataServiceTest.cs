using Tyuiu.KardonKD.Sprint3.Task4.V23.Lib;
namespace Tyuiu.KardonKD.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 244.656;
            Assert.AreEqual(res, wait);
        }
    }
}