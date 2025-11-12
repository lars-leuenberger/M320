using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Wasserfass;

namespace Wasserfass
{
    [TestClass()]
    public class WasserfassTests
    {
        [TestMethod()]
        public void Befuellen_NormalerFall()
        {
            var fass = new Wasserfass(100);
            fass.Befüllen(40);

            Assert.AreEqual(40, fass.Füllstand);
        }

        [TestMethod()]
        public void Befuellen_Ueberlauf_WirftException()
        {
            var fass = new Wasserfass(100);

            Assert.ThrowsException<WasserfassOverflowException>(() =>
            {
                fass.Befüllen(150);
            });
        }

        [TestMethod()]
        public void Befuellen_UngueltigeMenge_WirftArgumentException()
        {
            var fass = new Wasserfass(100);

            Assert.ThrowsException<ArgumentException>(() =>
            {
                fass.Befüllen(0);
            });
        }

        [TestMethod()]
        public void Entnehmen_NormalerFall()
        {
            var fass = new Wasserfass(100);
            fass.Befüllen(80);
            fass.Entnehmen(30);

            Assert.AreEqual(50, fass.Füllstand);
        }

        [TestMethod()]
        public void Entnehmen_Unterlauf_WirftException()
        {
            var fass = new Wasserfass(100);
            fass.Befüllen(20);

            Assert.ThrowsException<WasserfassUnderflowException>(() =>
            {
                fass.Entnehmen(50);
            });
        }

        [TestMethod()]
        public void Entnehmen_UngueltigeMenge_WirftArgumentException()
        {
            var fass = new Wasserfass(100);

            Assert.ThrowsException<ArgumentException>(() =>
            {
                fass.Entnehmen(0);
            });
        }

        [TestMethod()]
        public void Entleeren_SetztFuellstandAufNull()
        {
            var fass = new Wasserfass(100);
            fass.Befüllen(80);
            fass.Entleeren();

            Assert.AreEqual(0, fass.Füllstand);
        }

        [TestMethod()]
        public void Konstruktor_WirftFehlerBeiUngueltigerKapazitaet()
        {
            Assert.ThrowsException<ArgumentException>(() => new Wasserfass(0));
        }
    }
}
