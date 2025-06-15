using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksempeloppgaver_Muntlig_Eksamen
{
    internal class Øving_9_Klassen_Elev
    {
        string Fornavn { get; set; }
        string Etternavn { get; set; }
        int Karakter { get; set; }

        public Øving_9_Klassen_Elev(string fornavn, string etternavn, int karakter)
        {
            Fornavn = fornavn;
            Etternavn = etternavn;
            Karakter = karakter;
        }

        public override string ToString()
        {
            return $"{Fornavn} {Etternavn}";
        }
    }
}
