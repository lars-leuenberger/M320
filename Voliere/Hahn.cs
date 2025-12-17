using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere
{
    public class Hahn : Huhn
    {
        public Hahn(string name, string farbe, double maxFlugHoehe) : base(name, farbe, maxFlugHoehe) { }

        public override void Singe()
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) kräht.");
        }

        public void Stolziere()
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) stolziert.");
        }
    }
}
