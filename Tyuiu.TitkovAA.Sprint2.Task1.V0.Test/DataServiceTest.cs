using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint2.Task1.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint2.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            bool[] a = new bool[6] { true, false, true, true, true, false };
            CollectionAssert.AreEqual(a, dt.GetLogicOperations(135, 123, 455, 321));
        }
    }
}
