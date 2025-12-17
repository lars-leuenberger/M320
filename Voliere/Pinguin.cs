using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere
{
    internal class Pinguin : Vogel, ISchwimmFaehig
    {
        public Pinguin(string name, string farbe) : base(name, farbe) { }
        public override void Singe()
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) singt.");
        }

        public void Schwimme()
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) schwimmt.");
        }

        public void Tauche(double tiefe)
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) taucht {tiefe} tief.");
        }
    }
}
