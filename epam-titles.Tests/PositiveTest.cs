using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using epam_titles.SimpleCalculator;

namespace epam_titles.Tests
{
    [TestClass]
    public class PositiveTest
    {
        [TestMethod]
        public void Addition()
        {
            Assert.AreEqual(5, Calculator.Addition(3, 2));
        }
        [TestMethod]
        public void Substract()
        {
            Assert.AreEqual(5, Calculator.Substract(10, 5));
        }
        [TestMethod]
        public void Multiply()
        {
            Assert.AreEqual(6, Calculator.Multiply(3, 2));
        }
        [TestMethod]
        public void Divide()
        {
            Assert.AreEqual(5, Calculator.Divide(10, 2));
        }
    }
}
