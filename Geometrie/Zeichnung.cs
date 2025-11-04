using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class Zeichnung
    {
        public string Erstellungsdatum {  get; }
        public string Autor {  get; }
        public Punkt ReferenzPunkt { get; set; }
        
        public Zeichnung(string erstellungsdatum, string autor, Punkt referenzPunkt)
        {
            Erstellungsdatum = erstellungsdatum;
            Autor = autor;
            ReferenzPunkt = referenzPunkt;
        }

        Punkt p1 = new Punkt(10.0,1.0);
        Rechteck r1 = new Rechteck(new Punkt(10.0, 5.0), 10.0, 20.0);
        Rechteck q1 = new Rechteck(new Punkt(10.0, 30.0), 10.0, 10.0);
        Kreis k1 = new Kreis(new Punkt(10.0, 50.0), 10.0);

        public void Verschiebe(double deltaX, double deltaY)
        {
            ReferenzPunkt.X += deltaX;
            ReferenzPunkt.Y += deltaY;
        }

        public void Zeichne()
        {
            Console.WriteLine($"Figurtyp: Zeichnung | Referenzpunkt: {ReferenzPunkt.ToString} | Autor {Autor}");
        }
    }
}
