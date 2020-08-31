using Microsoft.VisualStudio.TestTools.UnitTesting;
using ass2_function;
namespace ass2_stringtest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            string res = p.function1("john");
            string actual = "john";
            Assert.AreEqual(res, actual);
        }
    }
}
