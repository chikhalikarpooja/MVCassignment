using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using stringmessage;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            showstring m = new showstring();
            string res = m.message();
            string actual = "";
            Assert.AreEqual(res, actual); 
        }  


        
    }
}
