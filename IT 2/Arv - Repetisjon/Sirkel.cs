using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv___Repetisjon
{
    internal class Sirkel : GeometriskFigur
    {
        public double Radius;

        public Sirkel(double radius, string name = "Sirkel") : base(name)
        {
            Radius = radius;
        }
    }
}
