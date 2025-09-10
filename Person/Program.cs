using System;
using System.Linq;

namespace PersonenApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Anzahl Personen (vorher): {Person.GetAnzPersonen()}");

            Person person1 = new Person();
            person1.Print();

            person1.Taufe("Fritzli");
            person1.Print();

            person1.Taufe("Fritz", "Müller");
            person1.Print();

            Person person2 = new Person("Lars");
            person2.Taufe("Nicolas");
            person2.Print();

            Person person3 = new Person("Lars", "Leuenberger");
            person3.Taufe("Günter", "Albert");
            person3.Print();

            Person person4 = new Person("Lars", "Leuenberger", 2008);
            Console.WriteLine($"FullName person4: {person4.GetFullName()}");
            person4.Print();

            Person fridl = person1;
            fridl.Taufe(fridl);

            fridl.Print();
            person1.Print();

            person1.Adresse = new Adresse(9000, "Bahnhofstrasse 1", "St. Gallen");
            person2.Adresse = new Adresse(8000, "Seestrasse 10", "Zürich");
            person3.Adresse = new Adresse(3000, "Bundesplatz 5", "Bern");

            Person[] personen = new[] { person1, person2, person3, person4 };

            Console.WriteLine("\n--- Alle Personen (mit Adresse) ---");
            foreach (var p in personen)
                p.PrintMitAdresse();

            string gesuchterNachname = "Müller";
            var gefundene = personen.FirstOrDefault(p =>
                string.Equals(p.Nachname, gesuchterNachname, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"\nSuche Nachname = \"{gesuchterNachname}\":");
            if (gefundene != null)
            {
                Console.WriteLine($"Gefunden: {gefundene.GetFullName()} (Id {gefundene.IdNr})");
                if (gefundene.Adresse != null)
                {
                    Console.Write("Adresse: ");
                    gefundene.Adresse.Print();
                }
                else
                {
                    Console.WriteLine("Keine Adresse vorhanden.");
                }
            }
            else
            {
                Console.WriteLine("Keine Person mit diesem Nachnamen gefunden.");
            }

            Console.WriteLine($"\nAnzahl Personen (am Schluss): {Person.GetAnzPersonen()}");
        }
    }
}
