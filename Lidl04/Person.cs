using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl04
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        protected int IdentNr { get; private set; }
        private string Key { get; set; }

        public Person(string name, string vorname, int identNr, string key)
        {
            Name = name;
            Vorname = vorname;
            IdentNr = identNr;
            Key = Key;
        }
        public virtual void Esse()
        {
            Console.WriteLine("Ich als Person {0} {1} {2} esse mit Messer und Gabel", Vorname, Name, IdentNr);
        }

        public abstract void Trage();
    }
}