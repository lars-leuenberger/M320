using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere
{
    public class Strauss : Vogel
    {
        public Strauss(string name, string farbe) : base(name, farbe) { }

        public override void Singe()
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) singt.");
        }

        public void Renne(double geschwindigkeit)
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) rennt {geschwindigkeit} schnell.");
        }
    }
}
