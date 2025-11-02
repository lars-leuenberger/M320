using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl01
{
    internal class Kunde : Person
    { 
        public double Umsatz { get; set; }

        public void Kaufe()
        {
            System.Console.WriteLine("Kunde {0} {1} kauft für {2}", Vorname, Name, Umsatz);
        }

        public override void Trage()
        {
            System.Console.WriteLine("Kunde {0} {1} kauft für trage Freizeitkleider", Vorname, Name);
        }
    }
}
