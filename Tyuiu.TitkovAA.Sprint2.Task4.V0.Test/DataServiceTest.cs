using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint2.Task4.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint2.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            double res = 76.977;
            Assert.AreEqual(res, dt.Calculate(4, 6));
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService dt = new DataService();
            double res = 72.074;
            Assert.AreEqual(res, dt.Calculate(5, 6));
        }
    }
}
