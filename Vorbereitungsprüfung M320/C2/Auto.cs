using Prüfungsvorbeitung_C2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prüfungsvorbeitung_C2
{
    internal class Auto: Fahrzeug
    {
        public int Sitze { get; private set; }

        public Auto(string marke, int baujahr, int sitze): base(marke, baujahr)
        {
            Sitze = sitze;
        }
        public override void InfoAusgeben()
        {
            base.InfoAusgeben();
            Console.WriteLine($"Sitze: {Sitze}");
        }

        // 🆕 Eigene Regel: 0.6 CHF/km
        public override double BerechneKosten(int kilometer)
        {
            return kilometer * 0.6;
        }

    }
}
