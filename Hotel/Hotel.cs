using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Hotel
    {
        public String Name {  get; set; }
        public String Adresse { get; set; }

        public Reception Reception { get; private set; }

        List<Zimmer> zimmers;
        List<Sitzungszimmer> sitzungszimmers;

        public Hotel(String Name, String Adresse, Reception Reception)
        {
            this.Name = Name;
            this.Adresse = Adresse;
            this.Reception = Reception;
        }
    }
}
