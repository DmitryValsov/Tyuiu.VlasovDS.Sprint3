﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VlasovDS.Sprint3.Task5.V21.Lib
{
    public class DataService : ISprint3Task5V21
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i = 0;
            int k = 0;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries = sumSeries + (((Math.Pow(x, 3)) * (Math.Cos(k))) + 2);
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
