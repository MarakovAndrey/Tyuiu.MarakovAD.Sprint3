using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MarakovAD.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int i = startValue; i <= stopValue; i++) {
                for (int d = 6; d <= i; d++) {
                    if (i % d == 0) {
                        res++;
                    }
                }
            }
            return res;
        }
    }
}
