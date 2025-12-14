using Microsoft.VisualStudio.TestTools.UnitTesting;
using Probepruefung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probepruefung.Tests
{
    [TestClass()]
    public class MotorradTests
    {
        [TestMethod()]
        public void BerechneKostenTestZero()
        {
            // Arrange, Act, Assert
            Motorrad motorrad = new Motorrad("KTM", 2025, false);

            double summe = motorrad.BerechneKosten(0);

            Assert.AreEqual(0.0, summe);
        }

        [TestMethod()]
        public void BerechneKostenTestPositive()
        {
            // Arrange, Act, Assert
            Motorrad motorrad = new Motorrad("KTM", 2025, false);

            double summe = motorrad.BerechneKosten(100);

            Assert.AreEqual(45.0, summe);
        }

        [TestMethod()]
        public void BerechneKostenTestNegative()
        {
            // Arrange, Act, Assert
            Motorrad motorrad = new Motorrad("KTM", 2025, false);

            double summe = motorrad.BerechneKosten(-100);

            Assert.AreEqual(-45.0, summe);
        }
    }
}