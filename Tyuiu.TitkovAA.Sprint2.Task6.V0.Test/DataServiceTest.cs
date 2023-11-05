using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint2.Task6.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint2.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            int res = dt.FindMonthDaysCount(4);
            Assert.AreEqual(30, res);

        }
    }
}
