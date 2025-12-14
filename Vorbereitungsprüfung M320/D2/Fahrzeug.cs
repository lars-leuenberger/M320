using Prüfungsvorbeitung_D2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prüfungsvorbeitung_D2
{
    public class Fahrzeug: Transportmittel
    {
        public string Marke { get; set; }
        public int Baujahr {  get; set; }

        public int Kilometerstand { get; set; }

        public Fahrzeug(string marke, int baujahr)
        {
            this.Marke = marke;
            this.Baujahr = baujahr;
        }

        public virtual void InfoAusgeben()
        {
            Console.WriteLine($"Ein Fahrzeug der Marke {this.Marke} mit Jahrgang {this.Baujahr}, km {this.Kilometerstand}");
            //Console.WriteLine("Ein Fahrzeug der Marke " + this.Marke + " mit Jahrgang " + this.Baujahr);
        }

        // Überladene Methode
        public void InfoAusgeben(string zusatzInfo)
        {
            Console.WriteLine($"Ein Fahrzeug der Marke {this.Marke} mit Jahrgang {this.Baujahr}, km {this.Kilometerstand} – {zusatzInfo}");
        }

        // 🆕 Standardregel: 0.5 CHF pro km
        public override double BerechneKosten(int kilometer)
        {
            return kilometer *  0.5;
        }
    }
}
