using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 20;
        private readonly int b = 10;
        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(30, BasicCalculator.Addition.Sum(a, b));
        }
    }
}