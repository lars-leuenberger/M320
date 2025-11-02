using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    internal class Torwart
    {
        public string Name { private set; get; }

        public void SchussHalten()
        {
            Console.WriteLine($"{Name} hält den Schuss vom Gegner!");
        }

        public void Abstoss()
        {
            Console.WriteLine($"{Name} macht einen Abstoss!");
        }

        public Torwart(string name)
        {
            this.Name = name;
        }
    }
}
