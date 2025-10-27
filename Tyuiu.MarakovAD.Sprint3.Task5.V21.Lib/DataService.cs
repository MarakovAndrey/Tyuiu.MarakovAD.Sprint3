using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MarakovAD.Sprint3.Task5.V21.Lib
{
    public class DataService : ISprint3Task5V21
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int i = startValue1; i <= stopValue1; i++) {
                for (int j = startValue2; j <= stopValue2; j++) {
                    res += (Math.Pow(x, 3) * Math.Cos(j)) + 2;
                }
            }
            return Math.Round(res,3);
        }
    }
}
