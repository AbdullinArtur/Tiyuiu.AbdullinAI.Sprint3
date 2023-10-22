using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint3.Task3.V10.Lib;

namespace Tyuiu.AbdullinAI.Sprint3.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string x = "gdfppf vfppt p";
            char y = 'p';
            string res = ds.DeleteCharInString(x, y);
            string wait = "gdff vft ";
            Assert.AreEqual(wait, res);
        }
    }
}
