﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KardonKD.Sprint3.Task2.V2.Lib
{
    public class DataService : ISprint3Task2V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            do
            {
                multSeries = multSeries * (Math.Sin(0.1) + startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multSeries, 3);
        }
    }
}
