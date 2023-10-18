using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint3.Task1.V14.Lib;

namespace Tyuiu.AbdullinAI.Sprint3.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double t; t = 0.7;
            int x, y; x = 1; y = 14;
        
            double res = ds.GetMultiplySeries(t, x, y);
            double wait = 1.773;
            Assert.AreEqual(res, wait);
        }
    }
}
