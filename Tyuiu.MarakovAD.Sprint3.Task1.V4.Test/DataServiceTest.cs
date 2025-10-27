using Tyuiu.MarakovAD.Sprint3.Task1.V4.Lib;
namespace Tyuiu.MarakovAD.Sprint3.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSeries(1, 3);
            double wait = 1.361;
            Assert.AreEqual(wait, res);
        }
    }
}
