using Prüfungsvorbeitung_D1;

namespace Prüfungsvorbeitung_D1
{
    internal class Program
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
        }
    }
}
