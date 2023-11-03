using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint4.Task3.V22.Lib;

namespace Tyuiu.SavenkovaME.Sprint4.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] num = new int[5,5] { { 4, 3, 5, 4, 4 }, { 4, 4, 6, 9, 4 }, { 5, 5, 5, 5, 5 }, { 5, 4, 6, 9, 5 }, { 6, 5, 6, 5, 5 } };
            int res = ds.Calculate(num);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
