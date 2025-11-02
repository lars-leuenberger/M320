using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl01
{
    internal abstract class Person
    {
        public String Name { get; set; }
        public String Vorname { get; set; }

        public void Esse()
        {
            System.Console.WriteLine("Ich als Person {0} {1} esse mit Messer und Gabel", Vorname, Name);
        }

        public abstract void Trage();
    }
}
