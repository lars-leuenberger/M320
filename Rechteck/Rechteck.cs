using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    public class Rechteck
    {
        private readonly static int _nextId = 1;

        public int Id { get; }

        public string Name { get; set; } = string.Empty;

        public double Laenge { get; set; }

        public double Breite { get; set; }

        public readonly Punkt Position { get; }

        public readonly int Winkelsumme { get; } = 360;

        
    }
}
