namespace Prüfungsvorbeitung_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        var f1 = new Fahrzeug("Alpina", 2018);
        var f2 = new Fahrzeug("Gipfel", 2020);

        f1.InfoAusgeben();
        f2.InfoAusgeben();        }
    }
}
