using Tyuiu.MarakovAD.Sprint3.Task5.V21.Lib;
namespace Tyuiu.MarakovAD.Sprint3.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(2, 1, 1, 3, 10);
            double wait = 25.981;
            Assert.AreEqual(wait, res);
        }
    }
}
