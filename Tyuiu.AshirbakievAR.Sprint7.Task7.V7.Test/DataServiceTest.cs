using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint7.Task7.V7.Lib;

namespace Tyuiu.AshirbakievAR.Sprint7.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] matrix = { 2, 3, 4, 5, 6 };
            Assert.AreEqual(2, ds.Min(matrix));
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            int[] matrix = { 1, 2, 3, 4, 5, 6 };
            Assert.AreEqual(6, ds.Max(matrix));
        }
    }
}
