using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    internal class Rektangel : GeometriskeFigurer
    {
        public double Bredde { get; set; }
        public double Lengde { get; set; }

        public Rektangel(string navn, double bredde, double lengde) : base(navn)
        {
            Bredde = bredde;
            Lengde = lengde;
        }

        public double BeregnAreal()
        {
            return Lengde * Bredde;
        }

        public double BeregnOmkrets()
        {
            return 2 * Lengde + 2 * Bredde;
        }
    }
}
