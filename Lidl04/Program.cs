using System.Text;

namespace Lidl04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            //Person person1 = new Person() { Vorname = "Hans", Name = "Meier" };
            Kunde kunde1 = new Kunde("Fritz", "Mueller", 100, "Key100", 1000.0);
            Lagerist lagerist1 = new Lagerist("Joe", "Manser", 101, "Key101", 180);
            Kleinkind kleinkind1 = new Kleinkind("Kiddy", "Kid", 102, "Key102", 3);
            List<Person> personen = new List<Person>();

            //person1.Esse();
            kunde1.Esse();
            kunde1.Kaufe();
            kunde1.Trage();
            lagerist1.Esse();
            lagerist1.LagereEin();
            lagerist1.Trage();
            kleinkind1.Esse();
            kleinkind1.Trage();

            Console.WriteLine(kunde1.Umsatz);
        }
    }
}