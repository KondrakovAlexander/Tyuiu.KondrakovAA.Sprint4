using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint4.Task7.V26.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual(18432, resp.Calculate(5, 3, "351268459614723"));
        }
    }
}
