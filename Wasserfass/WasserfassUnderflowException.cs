using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    public class WasserfassUnderflowException : WasserfassException
    {
        public WasserfassUnderflowException() : base("Unterlauf: Es wurde zu viel Wasser entnommen.") { }
    }
}
