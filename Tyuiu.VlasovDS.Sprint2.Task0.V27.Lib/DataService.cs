﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VlasovDS.Sprint3.Task0.V27.Lib
{
    public class DataService : ISprint3Task0V27
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res += Math.Pow((4 / (Math.Pow(i, value))), 2);
            }
            return Math.Round(res, 3);
        }
    }
}
