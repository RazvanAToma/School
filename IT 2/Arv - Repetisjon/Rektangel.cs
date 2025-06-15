using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv___Repetisjon
{
    internal class Rektangel : GeometriskFigur
    {
        public double Bredde;
        public double Lengde;

        public Rektangel(double Bredde, double Lengde, string name = "Rektangel") : base(name)
        {

        } 
    }
}
