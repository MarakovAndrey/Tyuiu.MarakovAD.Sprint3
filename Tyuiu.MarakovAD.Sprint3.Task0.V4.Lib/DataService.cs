using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MarakovAD.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            int i;
            for (i = startValue; i <= stopValue; i++) {
                p *= Math.Sin(0.1) + i;
            }

            return Math.Round(p,3);
        }
    }
}
