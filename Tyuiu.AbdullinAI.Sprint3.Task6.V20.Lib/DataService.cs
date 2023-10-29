using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AbdullinAI.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int k = 0;
            for (int i = startValue; i <= stopValue; i++)
            {               
                for (int d = 1; d <= i; d++)
                {
                    if ((i % d == 0) && (d < 12))
                    {
                        k += 1;
                    }                   
                }               
            }
            return k;
        }
    }
}
