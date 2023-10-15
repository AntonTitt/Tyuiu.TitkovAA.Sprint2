using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint2.Task3.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint2.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            Assert.AreEqual(0.75, dt.Calculate(0));
        }
    }
}
