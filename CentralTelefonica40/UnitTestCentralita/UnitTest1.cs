using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaCentralita;
using System.Collections.Generic;

namespace UnitTestCentralita
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificarLlamada()
        {
            Centralita c = new Centralita("test");
            
            Assert.IsNotNull(c.Llamadas);
        }
        
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void VerificarCentralitaExeption()
        {
            Centralita c = new Centralita("Test");
            Local l1 = new Local("Lanus", 22, "Gerli", 29);
            Local l2 = new Local(l1, 29);
            Local l3 = new Local("saraza", 12, "otra", 22);
            c += l1;
            c += l2;
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void VerificarLlamadaProvincial()
        {
            Centralita c = new Centralita("Test");

            Provincial p1 = new Provincial("Lanus", Provincial.Franja.Franja_1,13, "gerli");
            Provincial p2 = new Provincial("Lanus", Provincial.Franja.Franja_2, 15, "gerli");

            c += p1;
            c += p2;
        }

        [TestMethod]
        public void VerificarLlamadas()
        {
            Centralita c = new Centralita("Test");

            Provincial p1 = new Provincial("Lanus", Provincial.Franja.Franja_2, 13, "gerli");
            Provincial p2 = new Provincial("Lanus", Provincial.Franja.Franja_2, 13, "gerli");
            Local l1 = new Local("Lanus", 22, "Gerli", 29);
            Local l2 = new Local(l1, 29);

            Assert.IsTrue(p1 == p2);
            Assert.IsTrue(l1 == l2);
            Assert.IsFalse(p1 == l1);
            Assert.IsFalse(p1 == l2);
            Assert.IsFalse(p2 == l1);
            Assert.IsFalse(p2 == l2);
        }
    }
}
