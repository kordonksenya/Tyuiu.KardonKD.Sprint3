﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KardonKD.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Cos(x) + (4 * x) / 2 - Math.Sin(x) * 3 * x), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
