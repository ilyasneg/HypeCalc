using System;
using CalcLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalcLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            var calc = new Calculator();
            var result = calc.Sum("3", "2");
            
            Assert.AreEqual("5", result);
        }

        [TestMethod]
        public void TestSub()
        {
            var calc = new Calculator();
            var result = calc.Sub("10", "3");

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestMult()
        {
            var calc = new Calculator();
            var result = calc.Mult("2", "4");

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestDiv()
        {
            var calc = new Calculator();
            var result = calc.Div("30", "3");

            Assert.AreEqual(10.0, result);
        }

        [TestMethod]
        public void TestPow()
        {
            var calc = new Calculator();
            var result = calc.Pow("-4", "2");

            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void TestMod()
        {
            var calc = new Calculator();
            var result = calc.Mod("3", "2");

            Assert.AreEqual(1, result);
        }

    }
}
