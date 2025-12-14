using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probepruefung
{
    internal class Fahrzeug : Transportmittel
    {
        public string Marke { get; set; }
        public int Baujahr { get; set; }
        public int Kilometerstand { get; set; }
        public Fahrzeug(string marke, int baujahr)
        {
            Marke = marke;
            Baujahr = baujahr;
        }

        public virtual void InfoAusgabe()
        {
            Console.WriteLine($"Ein Fahrzeug der Marke {Marke} mit Baujahr {Baujahr}, km: {Kilometerstand}");
        }

        public virtual void InfoAusgabe(string zusatzInfo)
        {
            Console.WriteLine($"{Marke}({Baujahr}), km: {Kilometerstand} - {zusatzInfo}");
        }

        public override double BerechneKosten(int kilometer)
        {
            return kilometer * 0.5;
        }
    }
}
