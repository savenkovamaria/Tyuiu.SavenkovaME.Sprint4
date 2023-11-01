using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint4.Task2.V1.Lib;

namespace Tyuiu.SavenkovaME.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] num = { 1, 2, 3, 9, 5, 2, 4, 2, 1, 3 };
            int res = ds.Calculate(num);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}
