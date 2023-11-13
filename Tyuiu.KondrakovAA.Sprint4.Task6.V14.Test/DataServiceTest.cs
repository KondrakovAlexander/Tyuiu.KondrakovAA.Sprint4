using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint4.Task6.V14.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = { "asd", "Firefox", "fgh", "Opera", "Edge", "Internet Explorer", "Brave" };
            string[] res = ds.Calculate(mas);
            string[] wait = new string[] { "asd", "fgh" };
            Assert.AreEqual(wait, res);
        }
    }
}
