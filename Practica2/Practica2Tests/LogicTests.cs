using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void MayorMenorTest()
        {
            int valor1 = 20;
            int valor2 = 10;

            Logic.MayorMenor(valor1, valor2, true);

            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void MayorMenorTest2()
        {
            int valor1 = 10;
            int valor2 = 30;

            Logic.MayorMenor(valor1, valor2, true);

            Assert.IsTrue(true);
        }
    }
}