using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    internal class Kvadrat : Rektangel
    {
        public double Lengde { get; set; }

        public Kvadrat  (string navn, double lengde) : base("Kvadrat", lengde, lengde)
        {
            Lengde = lengde;
        }
    }
}
