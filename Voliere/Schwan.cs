using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere
{
    public class Schwan : Vogel, IFlugFaehig, ISchwimmFaehig
    {
        public double MaxFlugHoehe { get; set; }
        public Schwan(string name, string farbe, double maxFlugHoehe) : base(name, farbe)
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

        public void Schwimme()
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) schwimmt.");
        }

        public void Balze(int level)
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) balzt auf Level {level}.");
        }
    }
}
