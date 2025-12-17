using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voliere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void Schwan_MaxFlugHoehe_10_5_Erwartet_10_5()
        {
            Schwan schwan = new Schwan("TestSchwan", "TestFarbe", 10.5);
            double maxFlugHoehe = schwan.MaxFlugHoehe;
            Assert.AreEqual(10.5, maxFlugHoehe, 0.001);
        }

        [TestMethod()]
        public void IFluegFaehig_throws_Exception()
        {
            List<IFlugFaehig> f = new List<IFlugFaehig> { new Nachtigall("TestNachtigall", "TestFarbe", 10.0), new Hahn("TestHahn", "TestFarbe", 10.0), new Henne("TestHenne", "TestFarbe", 10.0), new Schwan("TestSchwann", "TestFarbe", 10.0) };

            foreach (var item in f)
            {
                Assert.ThrowsException<MaximaleFlugHoeheUeberschrittenException>(() => item.Fliege(20.0));
            }
        }
    }
}