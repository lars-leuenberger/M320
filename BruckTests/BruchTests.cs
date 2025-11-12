using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass()]
    public class BruchTests
    {
        [TestMethod()]
        public void Konstruktor_KorrektNormiertUndGekuerzt()
        {
            Bruch b = new Bruch(-2, -4);
            Assert.AreEqual(1, b.Zaehler);
            Assert.AreEqual(2, b.Nenner);
        }

        [TestMethod()]
        public void Konstruktor_NennerNull_WirftException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Bruch(1, 0));
        }

        [TestMethod()]
        public void AsDouble_BerechnetKorrekt()
        {
            Bruch b = new Bruch(1, 2);
            Assert.AreEqual(0.5, b.AsDouble(), 0.0001);
        }

        [TestMethod()]
        public void BildeKehrwert_FunktioniertKorrekt()
        {
            Bruch b = new Bruch(2, 3);
            Bruch kehrwert = b.BildeKehrwert();
            Assert.AreEqual(3, kehrwert.Zaehler);
            Assert.AreEqual(2, kehrwert.Nenner);
        }

        [TestMethod()]
        public void BildeKehrwert_VonNull_WirftException()
        {
            Bruch b = new Bruch(0, 5);
            Assert.ThrowsException<DivideByZeroException>(() => b.BildeKehrwert());
        }

        [TestMethod()]
        public void Multipliziere_ZweiBrueche()
        {
            Bruch b1 = new Bruch(2, 3);
            Bruch b2 = new Bruch(3, 4);
            Bruch result = Bruch.Multipliziere(b1, b2);
            Assert.AreEqual(1, result.Zaehler);
            Assert.AreEqual(2, result.Nenner); // 6/12 -> 1/2
        }

        [TestMethod()]
        public void Dividiere_ZweiBrueche()
        {
            Bruch b1 = new Bruch(1, 2);
            Bruch b2 = new Bruch(3, 4);
            Bruch result = Bruch.Dividiere(b1, b2);
            Assert.AreEqual(2, result.Zaehler);
            Assert.AreEqual(3, result.Nenner);
        }

        [TestMethod()]
        public void Addiere_ZweiBrueche()
        {
            Bruch b1 = new Bruch(1, 2);
            Bruch b2 = new Bruch(1, 3);
            Bruch result = Bruch.Addiere(b1, b2);
            Assert.AreEqual(5, result.Zaehler);
            Assert.AreEqual(6, result.Nenner);
        }

        [TestMethod()]
        public void Subtrahiere_ZweiBrueche()
        {
            Bruch b1 = new Bruch(3, 4);
            Bruch b2 = new Bruch(1, 2);
            Bruch result = Bruch.Subtrahiere(b1, b2);
            Assert.AreEqual(1, result.Zaehler);
            Assert.AreEqual(4, result.Nenner);
        }

        [TestMethod()]
        public void Operatoren_MultiplikationDivision()
        {
            Bruch b1 = new Bruch(2, 3);
            Bruch b2 = new Bruch(3, 4);
            Assert.AreEqual(new Bruch(1, 2), b1 * b2);
            Assert.AreEqual(new Bruch(8, 9), b1 / b2);
        }

        [TestMethod()]
        public void Gleichheit_GekuerztVergleichen()
        {
            Bruch b1 = new Bruch(1, 2);
            Bruch b2 = new Bruch(2, 4);
            Assert.IsTrue(b1 == b2);
            Assert.IsFalse(b1 != b2);
        }

        [TestMethod()]
        public void ToString_FormatiertKorrekt()
        {
            Bruch b = new Bruch(2, 3);
            Assert.AreEqual("2/3", b.ToString());
        }
    }
}
