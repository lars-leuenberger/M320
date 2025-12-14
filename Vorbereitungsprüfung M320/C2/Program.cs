using Prüfungsvorbeitung_C2;

namespace Prüfungsvorbeitung_C2
{
    internal class Program
    {
        public static void Main()
        {
            Fahrzeug f = new Fahrzeug("Alpina", 2018) { Kilometerstand = 24000 };
            Auto a = new Auto("BergAuto", 2021, 5) { Kilometerstand = 12000 };
            Motorrad m = new Motorrad("PassMot", 2019, true) { Kilometerstand = 8500 };

            int km = 120;

            Console.WriteLine("=== Kostenberechnung ===");
            Console.WriteLine($"Fahrzeug: {f.BerechneKosten(km)} CHF für {km} km");
            Console.WriteLine($"Auto:     {a.BerechneKosten(km)} CHF für {km} km");
            Console.WriteLine($"Motorrad: {m.BerechneKosten(km)} CHF für {km} km");
        }
    }
}
