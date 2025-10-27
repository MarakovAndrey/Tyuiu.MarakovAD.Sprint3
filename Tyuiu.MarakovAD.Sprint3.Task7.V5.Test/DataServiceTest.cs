using Tyuiu.MarakovAD.Sprint3.Task7.V5.Lib;
namespace Tyuiu.MarakovAD.Sprint3.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 70.14;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            Assert.AreEqual(valueWaitArray[0], res[0]);
        }
    }
}
