using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere
{
    public class Nachtigall : Vogel, IFlugFaehig
    {
        public double MaxFlugHoehe { get; set; }
        public Nachtigall(string name, string farbe, double maxFlugHoehe): base(name, farbe)
        {
            MaxFlugHoehe = maxFlugHoehe;
        }
        public override void Singe()
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) singt.");
        }

        public void Fliege(double hoehe)
        {
            if (this.MaxFlugHoehe >= hoehe)
            {
                Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) fliegt auf {hoehe} Meter.");
            }
            else
            {
                throw new MaximaleFlugHoeheUeberschrittenException($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) kann max. {hoehe} hoch fliegen");
            }
        }

        public void Jubiliere(int anzStrophen)
        {
            for (int i = 1; i <= anzStrophen; i++)
            {
                Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) jubiliert Strophe: {i}");
            }
        }
        public virtual void Fresse()
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) frisst.");
        }
    }
}
