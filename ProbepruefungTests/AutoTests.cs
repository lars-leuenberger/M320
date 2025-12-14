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
    public class AutoTests
    {
        [TestMethod()]
        public void BerechneKostenTestZero()
        {
            // Arrange, Act, Assert
            Auto auto = new Auto("Porsche", 2025, 2);

            double summe = auto.BerechneKosten(0);

            Assert.AreEqual(0.0, summe);
        }

        [TestMethod()]
        public void BerechneKostenTestPositive()
        {
            // Arrange, Act, Assert
            Auto auto = new Auto("Porsche", 2025, 2);

            double summe = auto.BerechneKosten(100);

            Assert.AreEqual(60, summe);
        }

        [TestMethod()]
        public void BerechneKostenTestNegative()
        {
            // Arrange, Act, Assert
            Auto auto = new Auto("Porsche", 2025, 2);

            double summe = auto.BerechneKosten(-100);

            Assert.AreEqual(-60.0, summe);
        }
    }
}