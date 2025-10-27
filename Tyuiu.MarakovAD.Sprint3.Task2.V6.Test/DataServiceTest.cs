using Tyuiu.MarakovAD.Sprint3.Task2.V6.Lib;
namespace Tyuiu.MarakovAD.Sprint3.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest 
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(0.25,1, 3);
            double wait = -0.377;
            Assert.AreEqual(wait, res);
        }
    }
}
