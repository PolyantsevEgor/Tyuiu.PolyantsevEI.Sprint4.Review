using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyantsevEI.Sprint4.TaskReview.V17.Lib;

namespace Tyuiu.PolyantsevEI.Sprint4.TaskReview.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string text = "753159864";
            int n = 3;
            int m = 3;
            int res = ds.Calculate(n, m, text);

            Assert.AreEqual(3, res);
        }
    }
}
