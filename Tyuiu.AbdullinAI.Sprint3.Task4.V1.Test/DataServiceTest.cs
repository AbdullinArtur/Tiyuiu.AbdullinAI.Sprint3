using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint3.Task4.V1.Lib;

namespace Tyuiu.AbdullinAI.Sprint3.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            double res = ds.Calculate(start, stop);
            double wait = 0.962;

            Assert.AreEqual(wait, res);

        }
    }
}
