using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint4.Task2.V1.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            int[] arr = new int[] { 1, 1, 1, 1,1, 1, 1, 1 };
            Assert.AreEqual(1, arr);
        }
    }
}
