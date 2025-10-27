using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MarakovAD.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            string res = "";
            foreach (char c in value) {
                if (Char.IsDigit(c)) {
                    res = Convert.ToString(c);
                }
            }
            return Convert.ToInt32(res);
        }
    }
}
