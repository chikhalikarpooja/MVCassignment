using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCase_Example;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            mathExample m = new mathExample();
            double res = m.add(20, 15);
            double actual = 35;
            double expected = res;
            Assert.AreEqual(expected, actual);

        }
    }
}
