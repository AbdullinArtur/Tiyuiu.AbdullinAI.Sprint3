using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint3.Task6.V20.Lib;

namespace Tyuiu.AbdullinAI.Sprint3.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int x = 20;
            int y = 32;

            int res = ds.GetSumTheDivisors(x,y);
            int wait = 41;

            Assert.AreEqual(res,wait);
        }
    }
}
