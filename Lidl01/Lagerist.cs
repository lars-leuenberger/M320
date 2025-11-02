using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl01
{
    internal class Lagerist:Person
    {
        public int Groesse { get; set; }
        public void LagereEin()
        {
            Console.WriteLine("Lagerist {0} {1} lagert Produkt mit Groesse {2}", Vorname, Name, Groesse);
        }

        public override void Trage()
        {
            System.Console.WriteLine("Kunde {0} {1} kauft für trage Arbeitskleider", Vorname, Name);
        }
    }
}
