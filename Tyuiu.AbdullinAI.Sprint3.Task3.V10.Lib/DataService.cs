using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AbdullinAI.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10
    {
        public string DeleteCharInString(string value, char item)
        {
            string c = "";
            foreach (char chr in value)
            {
                if (chr != item)
                {
                    c += chr;
                }
            }
            return c;
             
        }
    }
}
