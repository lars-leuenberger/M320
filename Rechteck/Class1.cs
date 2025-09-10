using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    internal class Quadrat
    {
        public string Name { get; init; }
        private double seitenlaenge;
        public double Seitenlaenge {  get { return seitenlaenge; } set { seitenlaenge = value < 0 ? 0 : value; } }
        public PunktQuadrat Punkt {  get; set; }
        public static int Typ { get; } = 2;

        public Quadrat()
        {
            Seitenlaenge = 0;
            Punkt = new PunktQuadrat(0, 0);
        }



    }
}
