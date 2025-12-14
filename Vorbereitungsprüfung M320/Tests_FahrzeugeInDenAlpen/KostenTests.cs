using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prüfungsvorbeitung_D2; // Namespace Hauptprojekt


namespace Tests_FahrzeugeInDenAlpen;

//Achtung: Die Klassen im Projekt D2 müssen public sein!

[TestClass]
public class KostenTests
{
    [TestMethod]
    public void Fahrzeug_BerechneKosten_120km_Erwartet60()
    {
        var f = new Fahrzeug("Alpina", 2018);
        double result = f.BerechneKosten(120);
        Assert.AreEqual(60.0, result, 0.001);
    }

    [TestMethod]
    public void Auto_BerechneKosten_120km_Erwartet72()
    {
        var a = new Auto("BergAuto", 2021, 5);
        double result = a.BerechneKosten(120);
        Assert.AreEqual(72.0, result, 0.001);
    }

    [TestMethod]
    public void Motorrad_BerechneKosten_120km_Erwartet54()
    {
        var m = new Motorrad("PassMot", 2019, true);
        double result = m.BerechneKosten(120);
        Assert.AreEqual(54.0, result, 0.001);
    }

    [TestMethod]
    public void BerechneKosten_0km_Erwartet0()
    {
        var a = new Auto("BergAuto", 2021, 5);
        var m = new Motorrad("PassMot", 2019, true);
        var f = new Fahrzeug("Alpina", 2018);

        Assert.AreEqual(0.0, a.BerechneKosten(0), 0.001);
        Assert.AreEqual(0.0, m.BerechneKosten(0), 0.001);
        Assert.AreEqual(0.0, f.BerechneKosten(0), 0.001);
    }
}
