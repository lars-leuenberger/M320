using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl04
{
    public class Kunde : Person
    {
        public double Umsatz { get; set; }

        public Kunde(string vorname, string name, int identNr, string Key, double umsatz) : base(vorname, name, identNr, Key)
        {
            Umsatz = umsatz;
        }

        public void Kaufe()
        {
            Console.WriteLine("Ich als Kunde {0} {1} {2} kaufe bei Lidl", Vorname, Name, IdentNr);
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Kunde {0} {1} {2} trage meine Einkäufe nach Hause", Vorname, Name, IdentNr);
        }

        public void TestKey()
        {
            Console.WriteLine(this.Umsatz); // ist public
            Console.WriteLine(this.IdentNr); // ist protected
            //Console.WriteLine(this.Key); // ist private
        }
    }
}