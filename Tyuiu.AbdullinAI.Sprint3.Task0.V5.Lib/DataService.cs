using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AbdullinAI.Sprint3.Task0.V5.Lib
{
    public class DataService : ISprint3Task0V5
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double allsum = 0;
            int i;

            for (i = startValue; i <= stopValue; i ++)
            {
                allsum = allsum + Math.Pow((1 / (Math.Sin(Math.PI * i / 180))), 2);
            }

            return Math.Round(allsum, 3);
        }
    }
}
