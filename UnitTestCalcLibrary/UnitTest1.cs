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

        }

    }
}
