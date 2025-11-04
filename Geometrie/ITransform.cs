using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public interface ITransform
    {
        void Verschiebe(double deltaX, double deltaY);
        void Skaliere(double faktorX, double faktorY);
        void Rotieren(int grad);
    }
}
