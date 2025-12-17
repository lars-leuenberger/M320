using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voliere
{
    public class MaximaleFlugHoeheUeberschrittenException : Exception
    {
        public MaximaleFlugHoeheUeberschrittenException() { }
        public MaximaleFlugHoeheUeberschrittenException(string message) : base(message) { }
    }
}
