using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl04
{
    public class Kleinkind : Person
    {
        public int Alter { get; set; }

        public Kleinkind(string vorname, string name, int identNr, string key, int alter) : base(vorname, name, identNr, key)
        {
            Alter = alter;
        }

        public override void Esse()
        {
            base.Esse();
            Console.WriteLine("... Nein, als Kleinkind {0} {1} {2} mit alter {3} natürlich von Hand...", Vorname, Name, IdentNr, Alter);
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Kleinkind {0} {1} {2} trage gar nicht", Vorname, Name, IdentNr);
        }
    }
}