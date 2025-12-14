using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probepruefung
{
    public class Fahrzeug : Transportmittel
    {
        public string Marke { get; set; }
        public int Baujahr { get; set; }
        public int Kilometerstand { get; set; }

        public Fahrzeug(string marke, int baujahr)
        {
            Marke = marke;
            Baujahr = baujahr;
        }

        /// <summary>
        /// Gibt sämtliche Felder aus.
        /// </summary>
        public virtual void InfoAusgeben()
        {
            Console.WriteLine($"Ein Fahrzeug der Marke {Marke} mit Baujahr {Baujahr}, km: {Kilometerstand}");
        }

        /// <summary>
        /// Gibt sämtliche Felder aus. Zudem kann eine zusatzInfo ausgegeben werden.
        /// </summary>
        /// <param name="zusatzInfo">Zusätzliche Info für Ausgabe als String.</param>
        public virtual void InfoAusgeben(string zusatzInfo)
        {
            Console.WriteLine($"Ein Fahrzeug der Marke {Marke} mit Baujahr {Baujahr}, km: {Kilometerstand} - {zusatzInfo}");
        }

        /// <summary>
        /// Berechnet Kosten pro Kilometer.
        /// </summary>
        /// <param name="kilometer">Anzahl Kilometer als int</param>
        /// <returns>Kosten für die Kilometer</returns>
        public override double BerechneKosten(int kilometer)
        {
            return kilometer * 0.5;
        }
    }
}
