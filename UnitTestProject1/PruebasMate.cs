using System;
using Clases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class PruebasMate
    {
        [TestMethod]
        public void Sumar()
        {
            Assert.AreEqual(5, Matematicas.Sumar(2, 3));
            Assert.AreNotEqual(4, Matematicas.Sumar(2, 3));
            Assert.AreEqual(10, Matematicas.Sumar(10, 0));
            Assert.AreNotEqual(11, Matematicas.Sumar(11, 3));
        }
        [TestMethod,ExpectedException(typeof(System.DivideByZeroException))]
        public void DividirXCeroYError()
        {
            Matematicas.Dividir(2, 0);
        }
        [TestMethod]
        public void Dividir()
        {
            Matematicas.Dividir(3, 2);
        }
    }
}
