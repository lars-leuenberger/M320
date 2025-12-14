using Prüfungsvorbeitung_C2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prüfungsvorbeitung_C2
{
    internal class Motorrad: Fahrzeug
    {
        public bool HatBeiwagen { get; private set; }

        public Motorrad(string marke, int baujahr, bool hatBeiwagen): base(marke, baujahr)
        {
            HatBeiwagen = hatBeiwagen;
        }

        public override void InfoAusgeben()
        {
            base.InfoAusgeben();
            Console.WriteLine($"Beiwagen: {(HatBeiwagen ? "ja" : "nein")}");
        }

        // 🆕 Eigene Regel: 0.45 CHF/km
        public override double BerechneKosten(int kilometer)
        {
            return kilometer * 0.45;
        }
    }
}
