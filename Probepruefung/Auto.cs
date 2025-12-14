using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probepruefung
{
    public class Auto : Fahrzeug
    {
        public int Sitze {  get; set; }
        public Auto (string marke, int baujahr, int sitze) : base(marke, baujahr)
        {
            Sitze = sitze;
        }

        public override void InfoAusgeben()
        {
            base.InfoAusgeben();
            Console.WriteLine($"Sitze: {Sitze}");
        }

        public override void InfoAusgeben(string zusatzInfo)
        {
            base.InfoAusgeben(zusatzInfo);
            Console.WriteLine($"Sitze: {Sitze}");
        }

        public override double BerechneKosten(int kilometer)
        {
            return kilometer * 0.6;
        }
        public void Buchen(string kunde)
        {
            Console.WriteLine($"Auto von {kunde} gebucht.");
        }
    }
}
