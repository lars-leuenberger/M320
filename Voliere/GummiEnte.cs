using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere
{
    public class GummiEnte : ISchwimmFaehig
    {
        public string Farbe {  get; set; }

        public GummiEnte(string farbe)
        {
            Farbe = farbe;
        }

        public void Schwimme()
        {
            Console.WriteLine($"{this.GetType} ({this.Farbe}) schwimmt.");
        }

        public void Blinke()
        {
            Console.WriteLine($"{this.GetType} ({this.Farbe}) blinkt.");
        }
    }
}
