using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    public interface Icalculator
    {
        public int Add(int a, int b);
        public int Sub(int a, int b);
        public int Mult(int a, int b);
        public int Div(int a, int b);
    }
}
