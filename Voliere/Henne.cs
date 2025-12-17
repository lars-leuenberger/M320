using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere
{
    public class Henne : Huhn
    {
        public Henne(string name, string farbe, double maxFlugHoehe) : base(name, farbe, maxFlugHoehe) { }

        public override void Singe()
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) gackert.");
        }

        public void LegeEi()
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) legt ein Ei in der Farbe {this.Farbe}.");
        }
    }
}
