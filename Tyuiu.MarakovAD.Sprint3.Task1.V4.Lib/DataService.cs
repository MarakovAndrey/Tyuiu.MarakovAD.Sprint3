using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MarakovAD.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double s = 0;
            int k = startValue;
            while (k <= stopValue) {
                s = s + Math.Pow((1.0/k),2);
                k++;
            }
            return Math.Round(s,3);
        }
    }
}
