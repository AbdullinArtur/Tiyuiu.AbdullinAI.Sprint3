using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AbdullinAI.Sprint3.Task2.V24.Lib
{
    public class DataService : ISprint3Task2V24
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 1;
            do            
            {
                sum = sum * (Math.Pow(value, startValue) + 4) * Math.Cos(value);
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(sum,3);
        }
    }
}
