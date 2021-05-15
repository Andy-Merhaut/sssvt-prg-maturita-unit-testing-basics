using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMaths basicMaths = new BasicMaths();
            double result = basicMaths.Add(10, 10);
            Assert.AreEqual(result, 20);
        }

        [TestMethod]
        public void Test_SubstractMethod()
        {
            BasicMaths basicMaths = new BasicMaths();
            double result = basicMaths.Deduct(10, 10);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
            BasicMaths basicMaths = new BasicMaths();
            double result = basicMaths.Divide(10, 5);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void Test_MultiplyMethod()
        {
            BasicMaths basicMaths = new BasicMaths();
            double result = basicMaths.Multiply(10, 10);
            Assert.AreEqual(100, result);
        }
    }
}
