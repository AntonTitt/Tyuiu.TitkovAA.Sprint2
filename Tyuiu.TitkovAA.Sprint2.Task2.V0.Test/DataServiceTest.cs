using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint2.Task2.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint2.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            bool res = true;
            Assert.AreEqual(res, dt.CheckDotInShadedArea(11, 6));
        }
    }
}
