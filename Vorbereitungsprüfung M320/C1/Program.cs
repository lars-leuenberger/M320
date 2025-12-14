using Prüfungsvorbeitung_C1;

namespace Prüfungsvorbeitung_C1
{
    internal class Program
    {
        public static void Main()
        {
            Fahrzeug f1 = new Fahrzeug("Alpina", 2018);
            f1.Kilometerstand = 24000;

            // Standardausgabe
            f1.InfoAusgeben();

            // Überladene Variante mit Zusatztext
            f1.InfoAusgeben("gebraucht, gut gewartet");
        }
    }
}
