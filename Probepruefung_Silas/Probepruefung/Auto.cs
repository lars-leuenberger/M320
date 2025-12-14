using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probepruefung
{
    internal class Auto : Fahrzeug, IBuchbar
    {
        public int Sitze { get; set; }

        public Auto(string marke, int baujahr, int sitze) : base(marke, baujahr)
        {
            Sitze = sitze;
        }

        public override void InfoAusgabe()
        {
            base.InfoAusgabe();
            Console.WriteLine($"Sitze: {Sitze}");
        }

        public override void InfoAusgabe(string zusatzInfo)
        {
            base.InfoAusgabe(zusatzInfo);
            Console.WriteLine($"Sitz: {Sitze}");
        }

        public override double BerechneKosten(int kilometer)
        {
            return kilometer * 0.6;
        }

        public void Buchen(string kunde)
        {
            Console.WriteLine($"Auto von {kunde} gebucht");
        }
    }
}
