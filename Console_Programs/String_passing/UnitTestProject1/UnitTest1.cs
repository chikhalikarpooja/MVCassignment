using Microsoft.VisualStudio.TestTools.UnitTesting;
using String_passing;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()  
        {
            string res = Program.name();
            string actual = "Welcome Friends";
            Assert.AreEqual(res, actual);

        }
    }
}
