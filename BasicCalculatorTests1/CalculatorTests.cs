using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using Operation;
namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly int a = 10;
        private readonly int b = 5;
        [TestMethod()]
        public void AddTest()
        {
            Calculator calcu = new Calculator();
            int c = calcu.Add(3, 5);
            Assert.AreEqual(8, c);
        }

        [TestMethod()]
        public void DividTest()
        {
            Assert.ThrowsException<DivideByZeroException>(()=>Division.Divsion(a,b));
        }
    }
}