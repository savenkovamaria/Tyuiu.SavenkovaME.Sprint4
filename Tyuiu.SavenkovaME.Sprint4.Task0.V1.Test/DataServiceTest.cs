using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint4.Task0.V1.Lib;

namespace Tyuiu.SavenkovaME.Sprint4.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] num = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            int res = ds.GetSumEvenArrEl(num);
            int wait = 20;
            Assert.AreEqual(wait, res);
        }
    }
}
