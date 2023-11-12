using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            int[,] wait = new int[5, 5] { { -1, -1, -1, -1, -1 },{ 2, 2, 2, 2, 2 },{ 2, 2, 2, 2, 2 },{ 2, 2, 2, 2, 2 },{ 2, 2, 2, 2, 2 } };
            Assert.AreEqual(20, resp.Calculate(wait));
        }
    }
}
