using B1;

namespace Prüfungsvorbeitung_B1
{
    internal class Program
    {
        public static void Main()
        {
            Auto a = new Auto("BergAuto", 2021, 5);
            a.Kilometerstand = 12000;

            Motorrad m = new Motorrad("PassMot", 2019, true);
            m.Kilometerstand = 8500;

            a.InfoAusgeben();
            Console.WriteLine();
            m.InfoAusgeben();
        }
    }
}
