using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class Kreis : ITransform, IDraw
    {
        private static int Anz = 1;
        public Punkt ReferenzPunkt { get; set; }
        public double Radius { get; set; }
        public int Id { get; private set; }
        public double Umfang
        {
            get { return (Radius + Radius) * 3.141; }
        }
        public double Flaeche
        {
            get { return Radius * Radius * 3.141; }
        }

        public Kreis (Punkt referenzPunkt, double radius)
        {
            Id = Anz;
            Anz++;
            ReferenzPunkt = referenzPunkt;
            Radius = radius;
        }

        public void Verschiebe(double deltaX, double deltaY)
        {
            ReferenzPunkt.X += deltaX;
            ReferenzPunkt.Y += deltaY;
        }

        public void Skaliere(double faktorX, double faktorY)
        {
            double faktor = (faktorX+faktorY)/2;
            Radius *= faktor;
        }

        public void Rotieren(int grad)
        {
            // Kreis bleibt gleich
        }

        public void Zeichne()
        {
            Console.WriteLine($"Figurtyp: Kreis | Referenzpunkt: {ReferenzPunkt.ToString} | Id: {Id} | Radius: {Radius}");
        }

        public override string ToString()
        {
            return $"Referenzpunkt: {ReferenzPunkt.ToString}, Radius: {Radius}.";
        }
    }
}
