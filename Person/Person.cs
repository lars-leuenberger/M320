using System;

namespace PersonenApp
{
    public class Person
    {
        private static int anzPersonen = 0;
        private static int nextId = 1;

        public int IdNr { get; }

        public string Vorname { get; private set; } = "Baby";

        public string Nachname { get; private set; } = string.Empty;

        public int Jahrgang { get; private set; } = DateTime.Now.Year;

        public Adresse? Adresse { get; set; }

        public Person()
        {
            IdNr = nextId++;

            Vorname = "Baby";
            Nachname = "Meier";
            Jahrgang = 2020;

            anzPersonen++;
        }

        public Person(string vorname)
        {
            IdNr = nextId++;

            Vorname = vorname?.Trim() ?? "Baby";
            Nachname = string.Empty;

            anzPersonen++;
        }

        public Person(string vorname, string nachname)
        {
            IdNr = nextId++;
            Vorname = vorname?.Trim() ?? "Baby";
            Nachname = nachname?.Trim() ?? string.Empty;

            anzPersonen++;
        }

        public Person(string vorname, string nachname, int jahrgang)
        {
            IdNr = nextId++;
            Vorname = vorname?.Trim() ?? "Baby";
            Nachname = nachname?.Trim() ?? string.Empty;
            Jahrgang = jahrgang;

            anzPersonen++;
        }

        public void Print()
        {
            Console.WriteLine($"[{IdNr}] {Nachname} {Vorname}, Jahrgang: {Jahrgang}");
        }

        public void PrintMitAdresse()
        {
            Print();
            if (Adresse != null)
            {
                Console.Write("    ");
                Adresse.Print();
            }
            else
            {
                Console.WriteLine("    (keine Adresse hinterlegt)");
            }
        }

        public void Taufe(string vorname)
        {
            Vorname = (vorname ?? "").Trim();
        }

        public void Taufe(string vorname, string nachname)
        {
            Vorname = (vorname ?? "").Trim();
            Nachname = (nachname ?? "").Trim();
        }

        public void Taufe(Person p)
        {
            if (p == null) return;
            Vorname = p.Vorname;
            Nachname = p.Nachname;
        }

        public string GetFullName() => $"{Nachname} {Vorname}".Trim();

        public static int GetAnzPersonen() => anzPersonen;
    }
}
