using Prüfungsvorbeitung_B1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
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
    }
}
