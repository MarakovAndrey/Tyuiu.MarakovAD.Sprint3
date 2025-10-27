﻿using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MarakovAD.Sprint3.Task7.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double res;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++) {
                res = Math.Round(((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2, 2);
                valueArray[count] = res;
                count++;
            }
            return valueArray;
        }
    }
}
