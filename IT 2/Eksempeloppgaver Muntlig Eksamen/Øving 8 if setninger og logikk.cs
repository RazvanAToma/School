using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksempeloppgaver_Muntlig_Eksamen
{
    internal class Øving_8_if_setninger_og_logikk
    {
        int tall { get; set; }

        public Øving_8_if_setninger_og_logikk(int tall)
        {
            this.tall = tall;
        }

        public string Value()
        {
            if (tall < 0)
            {
                return "Tallet er negativt";
            }
            else if (tall > 0)
            {
                return "Tallet er positivt";
            }
            else
            {
                return "Tallet er null";
            }
        }
    }
}
