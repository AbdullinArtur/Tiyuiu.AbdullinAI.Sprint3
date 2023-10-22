using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint3.Task2.V24.Lib;

namespace Tyuiu.AbdullinAI.Sprint3.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int x = 1;
            int y = 8;
            double res = ds.GetSumSeries(value, x ,y);
            double wait = 55217.446;
            Assert.AreEqual(wait, res);
        }
    }
}
