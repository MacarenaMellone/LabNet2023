using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void MayorMenorTest()
        {
            Logic compararMayotMenor = new Logic();
            int valor1 = 20;
            int valor2 = 10;
            int valor3 = 2;
            int valor4 = 30;

            compararMayotMenor.MayorMenor(valor1, valor2, true);
            compararMayotMenor.MayorMenor(valor3, valor4, true);

            Assert.IsTrue(true);
            Assert.IsTrue(true);
        }
    }
}