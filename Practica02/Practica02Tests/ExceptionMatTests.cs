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
    }
}