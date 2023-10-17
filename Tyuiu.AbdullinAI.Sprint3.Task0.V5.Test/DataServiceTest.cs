using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint3.Task0.V5.Lib;

namespace Tyuiu.AbdullinAI.Sprint3.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startvalue = 1;
            int stopvalue = 10;

            double res = ds.GetSumSeries(startvalue, stopvalue);
            double wait = 5090.929;

            Assert.AreEqual(wait, res);
        }
    }
}
