using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prüfungsvorbeitung_A1
{
    internal class Fahrzeug
    {
        public string Marke { get; set; }
        public int Baujahr {  get; set; }

        public Fahrzeug(string marke, int baujahr)
        {
            this.Marke = marke;
            this.Baujahr = baujahr;
        }

        public void InfoAusgeben()
        {
            Console.WriteLine($"Ein Fahrzeug der Marke {this.Marke} mit Jahrgang {this.Baujahr}");
            Console.WriteLine("Ein Fahrzeug der Marke " + this.Marke + " mit Jahrgang " + this.Baujahr);
        }
    }
}
