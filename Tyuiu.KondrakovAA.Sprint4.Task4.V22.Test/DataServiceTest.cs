using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint4.Task4.V22.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            int[,] matrix = new int[5,5] { { 1, 1, 1, 1, 1, }, { 2, 2, 2, 2, 2 }, { 3, 3, 3, 3, 3 }, { 4, 4, 4, 4, 4 }, { 5, 5, 5, 5, 5 } };
            int[,] wait = new int[5,5] { { 0, 0, 0, 0, 0 }, { 2, 2, 2, 2, 2 }, { 0, 0, 0, 0, 0 }, { 4, 4, 4, 4, 4 }, { 0, 0, 0, 0, 0 } };
            Assert.AreEqual(wait, resp.Calculate(matrix));
        }
    }
}
