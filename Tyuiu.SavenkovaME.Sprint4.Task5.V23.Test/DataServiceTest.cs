using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint4.Task5.V23.Lib;

namespace Tyuiu.SavenkovaME.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] num = new int[5, 5] { { -3, -6, -4, 6, 6 }, { 7, 5, 5, 5, 4 }, { 5, 3, 6, 7, 7 }, { 5, 3, 7, 4, 5 }, { -3, 7, -4, -3, 7 } };
            int[,] res = ds.Calculate(num);
            int[,] wait = new int[5, 5] { { 0, 0, 0, 6, 6 }, { 7, 5, 5, 5, 4 }, { 5, 3, 6, 7, 7 }, { 5, 3, 7, 4, 5 }, { 0, 7, 0, 0, 7 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
