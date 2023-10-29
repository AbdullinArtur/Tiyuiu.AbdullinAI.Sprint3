using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AbdullinAI.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {          
            int len = (stopValue - startValue) + 1;
            double[] a = new double[len];
            double b;
            int k = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double c = Math.Cos(x) + 2 * x - Math.Sin(x) * 3 * x;
                b = Math.Round(c, 2);
                a[k] = b;
                k++;
            }
            return a;

        }
    }
}
