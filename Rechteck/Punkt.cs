using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    internal class Punkt
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Punkt() : this(0, 0) { }

        public Punkt(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Verschiebe(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
