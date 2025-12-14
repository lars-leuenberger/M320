using B1;

namespace Prüfungsvorbeitung_B1
{
    internal class Program
    {
        public static void Main()
        {
            // Drei unterschiedliche Fahrzeugtypen erzeugen
            Fahrzeug f1 = new Fahrzeug("Alpina", 2018) { Kilometerstand = 30000 };
            Auto a1 = new Auto("BergAuto", 2021, 5) { Kilometerstand = 12000 };
            Motorrad m1 = new Motorrad("PassMot", 2019, true) { Kilometerstand = 8500 };

            // Polymorphe Liste: alle Typen als Fahrzeug gespeichert
            List<Fahrzeug> flotte = new List<Fahrzeug> { f1, a1, m1 };

            Console.WriteLine("=== Fahrzeugflotte ===\n");

            // Polymorpher Aufruf: Laufzeit entscheidet, welche Methode ausgeführt wird
            foreach (var fahrzeug in flotte)
            {
                fahrzeug.InfoAusgeben();
            }
        }
    }
}
