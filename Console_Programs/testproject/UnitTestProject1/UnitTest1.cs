using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testproject;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testaddmethod()
        {
            mathexample m = new mathexample();
            double res = m.add(10, 20);
            double actual = 30;
            double expected =res;
            Assert.AreEqual(actual, res);
        }
    }
}
