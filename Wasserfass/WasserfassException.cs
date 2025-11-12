using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    public class WasserfassException : Exception
    {
        public WasserfassException(string message) : base(message) { }
    }
}
