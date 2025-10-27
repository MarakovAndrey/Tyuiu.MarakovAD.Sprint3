using Tyuiu.MarakovAD.Sprint3.Task0.V4.Lib;
namespace Tyuiu.MarakovAD.Sprint3.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(1, 4);
            double wait = 29.351;
            Assert.AreEqual(res, wait);
        }
    }
}
