using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    public class Rechteck
    {
        public double Laenge { get; set; }
        public double Breite { get; set; }
        public Punkt Position { get; set; }

        public static readonly int winkelsumme = 360;
        
        public Rechteck() { }
        public Rechteck(Punkt position, double laenge, double breite)
        {
            this.Laenge = laenge;
            this.Breite = breite;
            this.Position = position;
        }

        public double BerechneFlaeche()
        {
            return Breite * Laenge;
        }

        public double BerechneUmfang()
        {
            return Breite * 2 + Laenge * 2;
        }

        public void Skaliere(double faktor)
        {
            this.Laenge *= faktor;
            this.Breite *= faktor;
        }

        public void Skaliere(double faktorX, double faktorY)
        {
            this.Laenge *= faktorX;
            this.Breite *= faktorY;
        }

        public void Verschiebe(double deltaX, double deltaY)
        {
            this.Position.X = deltaX;
            this.Position.Y = deltaY;
        }

        public void Positioniere(Punkt position)
        {
            this.Position = position;
        }

        public override string ToString()
        {
            string infos = $"Laenge: {this.Laenge}, Breite: {this.Breite}, Position: {this.Position}";
            return infos;
        }
    }
}
