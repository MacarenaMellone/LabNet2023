using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica2.Tests
{
    [TestClass()]
    public class ExceptionMatTests
    {
        [TestMethod()]
        public void SimpleExceptionTest()
        {
            ExceptionMat division = new ExceptionMat();
            int a = 20;
            int b = 2;
            int c = 25;
            int d = 5;
            int res = 10;
            int res2 = 5;

            int resultado = division.SimpleException(a, b);
            int resultado2 = division.SimpleException(c, d);

            Assert.AreEqual(res, resultado);
            Assert.AreEqual(res2, resultado2);
        }

        [TestMethod()]
        public void SimpleExceptionTest2()
        {
            ExceptionMat division = new ExceptionMat();
            int a = 50;
            int b = 0;

            division.SimpleException(a, b);

            Assert.IsTrue(true);
        }
    }
}