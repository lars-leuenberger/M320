
namespace Probepruefung
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto auto = new Auto("BergAuto", 2021, 5);
            Motorrad motorrad = new Motorrad("PassMot", 2019, hatBeiwage: true);
            Fahrzeug fahrzeug = new Fahrzeug("Alpina", 2018);

            List<Fahrzeug> fahrzeuge = new List<Fahrzeug> { fahrzeug, auto, motorrad};

            fahrzeug.Kilometerstand = 30000;
            auto.Kilometerstand = 12000;
            motorrad.Kilometerstand = 8500;

            auto.InfoAusgabe();
            Console.WriteLine();
            motorrad.InfoAusgabe();

            Console.WriteLine("\n\n=== Fahrzeugflotte ===");
            foreach (Fahrzeug fz in fahrzeuge)
            {
                fz.InfoAusgabe();
            }

            fahrzeug.InfoAusgabe("gebraucht, gut gewartet");

            Console.WriteLine("=== Kostenberechnung ===");
            Console.WriteLine($"Fahrzeug:\t {fahrzeug.BerechneKosten(120)} für 120 km");
            Console.WriteLine($"Auto:\t\t {auto.BerechneKosten(120)} für 120 km");
            Console.WriteLine($"Motorrad:\t {motorrad.BerechneKosten(120)} für 120 km");

            List<IBuchbar> buchungen = new List<IBuchbar> {auto, motorrad};
            Console.WriteLine("\n\n=== Buchungen ===");
            foreach (var item in buchungen)
            {
                item.Buchen("Anna");
            }

            Console.WriteLine("\n\n=== Tour-Kosten ===");
            Console.WriteLine($"Auto: {auto.BerechneKosten(120)} CHF für 120 km");
            Console.WriteLine($"Motorrad: {motorrad.BerechneKosten(120)} CHF für 120 km");

            //Console.WriteLine($"Aktueller Kilometerstand: {fahrzeug1.Kilometerstand}");
            //Console.WriteLine($"Aktueller Kilometerstand: {fahrzeug2.Kilometerstand}");
        }
    }
}
