using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probepruefung
{
    internal class Motorrad : Fahrzeug, IBuchbar
    {
        public bool HatBeiwagen { get; set; }

        public Motorrad (string marke, int baujahr, bool hatBeiwage) : base(marke, baujahr)
        {
            HatBeiwagen = hatBeiwage;
        }
        public override void InfoAusgabe()
        {
            base.InfoAusgabe();
            Console.WriteLine($"Beiwagen: {(HatBeiwagen ? "ja" : "nein")}");
        }

        public override void InfoAusgabe(string zusatzInfo)
        {
            base.InfoAusgabe(zusatzInfo);
            Console.WriteLine($"Beiwagen: {(HatBeiwagen ? "ja" : "nein")}");
        }

        public override double BerechneKosten(int kilometer)
        {
            return kilometer * 0.45;
        }

        public void Buchen(string kunde)
        {
            Console.WriteLine($"Motorrad von {kunde} gebucht");
        }
    }
}
