using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere
{
    public abstract class Huhn : Vogel, IFlugFaehig
    {
        public double MaxFlugHoehe { get; set; }
        public Huhn(string name, string farbe, double maxFlugHoehe) : base(name, farbe)
        {
            MaxFlugHoehe = maxFlugHoehe;
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

        public void Scharre(double tiefe)
        {
            Console.WriteLine($"{this.GetType} ({this.Id}, {this.Name}, {this.Farbe}) scharrt {tiefe} tief.");
        }
    }
}
