using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_2
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


        public double Volume()
        {
            return (4 / 3 * Math.PI * Math.Pow(Radius, 3));
        }

        public double Area()
        {
            return (4 * Math.PI * Math.Pow(Radius, 2));
        }

        public override string ToString()
        {
            string output = $"Planeten {Name} er {DistanceFromSun} milliarder km unna sola, og har radius på {Radius}km." +
                            $"{Name} har et volum på {Volume():E2}km^3, og et areal på {Area():E2}km^2";

            return output;
        }
    }
}
