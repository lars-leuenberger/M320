namespace Rechteck
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rechteck r1 = new Rechteck();
            Console.WriteLine(r1.ToString());
            r1.Laenge = 25.0;
            r1.Breite = 50.0;
            r1.Position = new Punkt(2.0, 3.0);
            Console.WriteLine(r1.ToString());

            Rechteck r2 = new Rechteck(new Punkt(5.0, 10.0), 10.0, 20.0);
            Console.WriteLine(r2.ToString());
            Console.WriteLine($"Flaeche: {r2.BerechneFlaeche()} und Umfang: {r2.BerechneUmfang}");
        }
    }
}
