using Tyuiu.KardonKD.Sprint3.Task5.V2.Lib;
namespace Tyuiu.KardonKD.Sprint3.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 35.658;
            Assert.AreEqual(res, wait);
        }
    }
}