using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    internal class Sirkel : GeometriskeFigurer
    {
        public double Radius { get; set; }

        public Sirkel(double radius) : base("Sirkel")
        {
            Radius = radius;
        }
    }
}
