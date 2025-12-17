using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere
{
    public interface IFlugFaehig
    {
        public double MaxFlugHoehe { get; set; }
        void Fliege(double hoehe);
    }
}
