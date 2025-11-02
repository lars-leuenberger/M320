using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Beamer
    {
        public String Name { get; set; }
        public String Aufloesung { get; private set; }

        public Beamer(string name, string aufloesung)
        {
            Name = name;
            Aufloesung = aufloesung;
        }
    }
}
