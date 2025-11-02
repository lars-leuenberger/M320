namespace Lidl01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Vorname = "Hans", Name = "Meier" };
            Kunde kunde1 = new Kunde() { Vorname = "Hans", Name = "Meier", Umsatz=250};
            Lagerist lagerist1 = new Lagerist() { Vorname = "Hans", Name = "Meier", Groesse = 250 };

            person1.Esse();
            kunde1.Esse();
            kunde1.Kaufe();
            lagerist1 .Esse();
            lagerist1.LagereEin();
            //person1.Kaufe(); -> geht nicht da Person keine Kaufe Methode hat
            //person1.LagereEin();
            Person person2 = kunde1;
            person2.Esse();
            // person2.Kaufe(); -> geht nicht da Person keine Kaufe Methode hat

        }
    }
}
