using Tyuiu.KardonKD.Sprint3.Task6.V27.Lib;
namespace Tyuiu.KardonKD.Sprint3.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 14;
            int stopValue = 20;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 129;

            Assert.AreEqual(wait, res);
        }
    }
}