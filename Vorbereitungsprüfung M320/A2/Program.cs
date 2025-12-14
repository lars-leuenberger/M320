namespace Prüfungsvorbeitung_A2
{
    internal class Program
    {
        public static void Main()
        {
            var f1 = new Fahrzeug("Alpina", 2018);
            f1.Kilometerstand = 25000;

            // Erhöhung um 500 km
            f1.Kilometerstand += 500;

            // Direkte Ausgabe in Main()
            Console.WriteLine($"Aktueller Kilometerstand: {f1.Kilometerstand}");
        }
    }
}
