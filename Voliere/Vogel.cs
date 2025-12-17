using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Voliere
{
    public abstract class Vogel
    {
        public readonly int Id;
        public string Name { get; set; }
        public string Farbe {  get; set; }
        private static int NextId { get; set; } = 100;

        public Vogel(string name, string farbe)
        {
            Id = NextId;
            NextId++;
            Name = name;
            Farbe = farbe;
        }

        public abstract void Singe();

        public virtual void Fresse()
        {
            Console.WriteLine($"Der Vogel frisst.");
        }

        public string toString()
        {
            return $"{this.GetType} ({this.Id}) heisst {this.Name} und ist {this.Farbe}).";
        }
    }
}
