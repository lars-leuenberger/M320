using Prüfungsvorbeitung_D2;

namespace Prüfungsvorbeitung_D2
{
    public class Program
    {
        public static void Main()
        {
            IBuchbar b1 = new Auto("BergAuto", 2021, 5) { Kilometerstand = 12000 };
            IBuchbar b2 = new Motorrad("PassMot", 2019, true) { Kilometerstand = 8500 };

            List<IBuchbar> buchungen = new List<IBuchbar> { b1, b2 };

            Console.WriteLine("=== Buchungen ===\n");
            foreach (var b in buchungen)
            {
                b.Buchen("Anna");
            }

            // Tour-Kostenberechnung
            int distanz = 120; // Beispiel: 120 km gemeinsame Tour
            double gesamtkosten = 0;

            Console.WriteLine("\n=== Tour-Kosten ===");
            foreach (var b in buchungen)
            {
                if (b is Fahrzeug f)
                {
                    double kosten = f.BerechneKosten(distanz);
                    Console.WriteLine($"{f.GetType().Name}: {kosten} CHF für {distanz} km");
                    gesamtkosten += kosten;
                }
            }

            Console.WriteLine($"\nGesamtkosten der Tour: {gesamtkosten} CHF");
        }
    }
}
