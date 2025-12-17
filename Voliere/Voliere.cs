using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere
{
    public class Voliere
    {
        public string Name { get; set; }
        public List<Vogel> voegel = new List<Vogel>();
        public List<GummiEnte> gummienten = new List<GummiEnte>();
        public int AnzVoegel
        {
            get {  return voegel.Count; }
        }

        public Voliere(string name)
        {
            Name = name;
        }

        public void fuegeVogelDazu(Vogel vogel)
        {
            voegel.Add(vogel);
        }

        public void zeigeBewohnerListe()
        {
            foreach (var item in voegel)
            {
                item.toString();
            }
        }

        public void LassSingen()
        {
            foreach (var item in voegel)
            {
                item.Singe();
            }
        }

        public void LassFressen()
        {
            foreach (var item in voegel)
            {
                item.Fresse();
            }
        }

        public void LassFliegen(double flughoehe)
        {
            foreach (var item in voegel)
            {
                if (item is IFlugFaehig flugfaehig)
                {
                    flugfaehig.Fliege(flughoehe);
                }
            }
        }

        public void LassSchwimmen()
        {
            foreach (var item in voegel)
            {
                if (item is ISchwimmFaehig schwimmFaehig)
                {
                    schwimmFaehig.Schwimme();
                }
            }
        }

        public void LassScharren(double tiefe)
        {
            foreach (var item in voegel)
            {
                if (item is Huhn huhn)
                {
                    huhn.Scharre(tiefe);
                }
            }
        }
    }
}
