using Microsoft.VisualStudio.TestTools.UnitTesting;
using ass3_add2no;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            int num = p.function1(16,15);
            int actual = 31;
            Assert.AreEqual(num, actual);                                                           
        }
    }
}
