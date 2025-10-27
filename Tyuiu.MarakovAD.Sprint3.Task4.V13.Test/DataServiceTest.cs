using Tyuiu.MarakovAD.Sprint3.Task4.V13.Lib;
namespace Tyuiu.MarakovAD.Sprint3.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-5, 5);
            double wait = 1.899;
            Assert.AreEqual(wait, res);
        }
    }
}
