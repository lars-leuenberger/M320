using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wasserfass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass.Tests
{
    [TestClass()]
    public class Calculator0Tests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator0 calculator = new Calculator0();
            int summe = calculator.Add(5, 20);
            Assert.AreEqual(25, summe, $"Fehlgeschlagen. Summe: {summe}");
        }

        [TestMethod()]
        public void SubTest()
        {
            Calculator0 calculator = new Calculator0();
            int summe = calculator.Sub(20, 5);
            Assert.AreEqual(15, summe, $"Fehlgeschlagen. Summe: {summe}");
        }

        [TestMethod()]
        public void MultTest()
        {
            Calculator0 calculator = new Calculator0();
            int summe = calculator.Mult(5, 20);
            Assert.AreEqual(100, summe, $"Fehlgeschlagen. Summe: {summe}");
        }

        [TestMethod()]
        public void DivTest()
        {
            Calculator0 calculator = new Calculator0();
            int summe = calculator.Div(20, 5);
            Assert.AreEqual(4, summe, $"Fehlgeschlagen. Summe: {summe}");
        }
    }
}