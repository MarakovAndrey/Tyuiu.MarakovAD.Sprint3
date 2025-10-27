using Tyuiu.MarakovAD.Sprint3.Task3.V13.Lib;
namespace Tyuiu.MarakovAD.Sprint3.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res = ds.ConvertStringToInt("?sd!! 5gh. s!");
            int wait = 5;
            Assert.AreEqual(res, wait);
        }
    }
}
