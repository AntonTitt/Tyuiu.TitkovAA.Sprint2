using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint2.Task7.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint2.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            double x1 = -0.5, x2 = 0.4, y1 = -0.5, y2 = 0.6, y3 = 0.3;
            bool res1 = dt.CheckDotInShadedArea(x1, y1), res2 = dt.CheckDotInShadedArea(x1, y2), res3 = dt.CheckDotInShadedArea(x2, y3), res4 = dt.CheckDotInShadedArea(x2, y2), res5 = dt.CheckDotInShadedArea(x2, y1);
            Assert.AreEqual(true, res1);
            Assert.AreEqual(true, res2);
            Assert.AreEqual(false, res3);
            Assert.AreEqual(true, res4);
            Assert.AreEqual(false, res5);

        }
    }
}
