namespace Probepruefung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug f1 = new Fahrzeug("Alpina", 2018);
            f1.Kilometerstand = 30000;

            Auto a1 = new Auto("BergAuto", 2021, 5);
            a1.Kilometerstand = 12000;

            Motorrad m1 = new Motorrad("PassMot", 2019, true);
            m1.Kilometerstand = 8500;

            List<Fahrzeug> flotte = new List<Fahrzeug> { f1, a1, m1 };

            Console.WriteLine($"=== Fahrzeugflotte ===");

            foreach (var fahrzeug in flotte)
            {
                fahrzeug.InfoAusgeben();
            }

            Console.WriteLine($"=== Buchungen ===");
            a1.Buchen("Anna");
            m1.Buchen("Anna");

            Console.WriteLine("=== Tour-Kosten ===");
            Console.WriteLine($"Auto: {a1.BerechneKosten(120)} CHF für 120 km");
            Console.WriteLine($"Motorrad: {m1.BerechneKosten(120)} CHF für 120 km");
        }
    }
}
