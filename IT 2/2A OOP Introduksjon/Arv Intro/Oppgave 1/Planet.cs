using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_1
{
    internal class Planet
    {
        public string Name { get; set; }
        public double DistanceFromSun { get; set; }
        public double Radius { get; set; }

        public Planet(string name, double distanceFromSun, double radius)
        {
            Name = name;
            DistanceFromSun = distanceFromSun;
            Radius = radius;
        }

        public override string ToString()
        {
            string output = $"Planeten {Name} er {DistanceFromSun} milliarder km unna sola, og har radius på {Radius} km";

            return output;
        }
    }
}
