using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.Tests
{
    [TestClass()]
    public class LogicTests
    {

        [TestMethod()]
        public void ComparaMayorMenorTest()
        {
            Logic compararMayotMenor = new Logic();
            int valor1 = 20;
            int valor2 = 10;
            int valor3 = 2;
            int valor4 = 30;

            compararMayotMenor.ComparaMayorMenor(valor1, valor2, true);
            compararMayotMenor.ComparaMayorMenor(valor3, valor4, true);

            Assert.IsTrue(true);
            Assert.IsTrue(true);
        }

    }
}