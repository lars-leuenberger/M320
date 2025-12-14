using Prüfungsvorbeitung_B1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
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

    }
}
