using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica2.Tests
{
    [TestClass()]
    public class ExceptionMatTests
    {
        [TestMethod()]
        public void SimpleExceptionTest()
        {
            int a = 50;
            int b = 2;

            ExceptionMat.SimpleException(a, b);

            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void SimpleExceptionTest2()
        {
            int a = 50;
            int b = 0;

            ExceptionMat.SimpleException(a, b);

            Assert.IsTrue(true);
        }
    }
}