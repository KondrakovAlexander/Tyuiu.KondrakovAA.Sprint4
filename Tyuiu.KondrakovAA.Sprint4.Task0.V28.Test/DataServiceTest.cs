using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint4.Task0.V28.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            int[] arr = new int[] { 2, 3, 4, 5, 6, 7 };
            Assert.AreEqual(48, resp.GetMultEvenArrEl(arr));
        }
    }
}
