using System;

namespace PersonenApp
{
    public class Adresse
    {
        public int PLZ { get; set; }
        public string Strasse { get; set; }
        public string Wohnort { get; set; }

        public Adresse(int plz, string strasse, string wohnort)
        {
            PLZ = plz;
            Strasse = strasse?.Trim() ?? "";
            Wohnort = wohnort?.Trim() ?? "";
        }

        public void Print()
        {
            Console.WriteLine($"{Strasse}, {PLZ} {Wohnort}");
        }

        public override string ToString() => $"{Strasse}, {PLZ} {Wohnort}";
    }
}
