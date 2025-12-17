namespace Voliere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vogel> voegel = new List<Vogel> { new Nachtigall("TestNachtigall", "TestFarbe", 20.0), new Hahn("TestHahn", "TestFarbe", 5.0), new Henne("TestHenne", "TestFarbe", 10.0), new Schwan("TestSchwann", "TestFarbe", 10.0), new Strauss("TestStrauss", "TestFarbe"), new Pinguin("TestPinguin", "TestFarbe") };

            Voliere voliere = new Voliere("TestVoliere");

            foreach (var item in voegel)
            {
                voliere.fuegeVogelDazu(item);
            }

            Console.WriteLine($"==================================\nsingen\n==================================\n\n");
            voliere.LassSingen();

            Console.WriteLine($"==================================\nfliegen\n==================================\n\n");
            voliere.LassFliegen(10.0);

            Console.WriteLine($"==================================\nschwimmen\n==================================\n\n");
            voliere.LassSchwimmen();

            Console.WriteLine($"==================================\nscharren\n==================================\n\n");
            voliere.LassScharren(5.0);
        }
    }
}
