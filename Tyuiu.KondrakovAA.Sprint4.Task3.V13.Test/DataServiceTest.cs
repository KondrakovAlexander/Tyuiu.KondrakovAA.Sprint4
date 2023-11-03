using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint4.Task3.V13.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            int[,] arr = new int[5, 5] { {4,7,4,2,1},{6,7,3,6,5},{6,5,3,3,5},{4,4,6,4,7},{2,1,2,3,4} };
            Assert.AreEqual(22, resp.Calculate(arr));
        }
    }
}
