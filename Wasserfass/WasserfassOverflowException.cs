using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    public class WasserfassOverflowException : WasserfassException
    {
        public WasserfassOverflowException() : base("Überlauf: Das Wasserfass wurde überfüllt.") { }
    }
}
