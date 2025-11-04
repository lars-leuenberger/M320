using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class Rechteck : ITransform, IDraw
    {
        private static int Anz = 1;
        public Punkt ReferenzPunkt { get; set; }
        public double Breite { get; set; }
        public double Laenge { get; set; }
        public int Id { get; private set; }
        public double Umfang
        {
            get { return (Breite + Laenge) * 2; }
        }
        public double Flaeche
        {
            get { return Breite * Laenge; }
        }

        public Rechteck(Punkt referenzPunkt, double breite, double laenge)
        {
            Id = Anz;
            Anz++;
            ReferenzPunkt = referenzPunkt;
            Breite = breite;
            Laenge = laenge;
        }

        public void Verschiebe(double deltaX, double deltaY)
        {
            ReferenzPunkt.X += deltaX;
            ReferenzPunkt.Y += deltaY;
        }

        public void Skaliere(double faktorX, double faktorY)
        {
            Breite *= faktorX;
            Laenge *= faktorY;
        }

        public void Rotieren(int grad)
        {
            if (grad > 315 || grad <= 45)
            {
                return;
            }
            else if (grad > 45 && grad <= 135)
            {
                (Breite, Laenge) = (Laenge, Breite);
            }
            else if (grad > 135 && grad <= 225)
            {
                (Breite, Laenge) = (-Breite, -Laenge);
            }
            else
            {
                (Breite, Laenge) = (-Laenge, Breite);
            }
        }

        public void Zeichne()
        {
            Console.WriteLine($"Figurtyp: Rechteck | Referenzpunkt: {ReferenzPunkt.ToString} | Id: {Id} | Breite: {Breite} | Länge: {Laenge}");
        }


        public override string ToString()
        {
            return $"Referenzpunkt: {ReferenzPunkt.ToString}, Breite: {Breite}, Länge: {Laenge}.";
        }
    }
}
