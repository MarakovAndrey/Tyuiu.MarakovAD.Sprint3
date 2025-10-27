using Tyuiu.MarakovAD.Sprint3.Task6.V14.Lib;
namespace Tyuiu.MarakovAD.Sprint3.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res = ds.GetSumTheDivisors(7, 16);
            int wait = 13;
            Assert.AreEqual(res, wait);
        }
    }
}
