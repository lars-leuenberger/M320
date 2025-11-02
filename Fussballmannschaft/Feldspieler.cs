using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    internal class Feldspieler
    {
        public string Name { private set; get; }

        public void AufsTorSchiessen()
        {
            Console.WriteLine($"{Name} schiesst aufs Tor!");
        }

        public void Graetschen()
        {
            Console.WriteLine($"{Name} macht eine Blutgraetsche!");
        }

        public void Dribbeln()
        {
            Console.WriteLine($"{Name} dribbelt den Gegner schwindlich!");
        }

        public Feldspieler(string name)
        {
            this.Name = name;
        }
    }
}
