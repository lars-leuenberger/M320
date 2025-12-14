using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prüfungsvorbeitung_D1
{
    internal abstract class Transportmittel
    {
        public abstract double BerechneKosten(int kilometer);
    }
}
