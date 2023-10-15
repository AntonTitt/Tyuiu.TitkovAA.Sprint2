using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint2.Task5.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint2.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();

            string res = dt.FindDateOfPreviousDay(1, 5, 7);

            Assert.AreEqual(res, "год: 1 день: 6 месяц: май");
        }
    }
}
