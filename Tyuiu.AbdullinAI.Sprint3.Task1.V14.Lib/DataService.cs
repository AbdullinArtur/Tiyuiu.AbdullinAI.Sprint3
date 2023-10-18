using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint3.Task1.V14.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AbdullinAI.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {           
            double sum = 0; 
            while (startValue <= stopValue)
            {
                sum += ( Math.Pow(value, startValue) + 1/(startValue + 1) ) * Math.Cos(value);
                startValue++;
            }
            return Math.Round(sum, 3);
        }
    }
}
