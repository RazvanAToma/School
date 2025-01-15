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
        public float DistanceFromSun { get; set; }
        public float Radius { get; set; }

        public Planet(string name, float distanceFromSun, float radius)
        {
            Name = name;
            DistanceFromSun = distanceFromSun;
            Radius = radius;
        }

        public double Volume()
        {
            double volume = (4 / 3) * Math.PI * Math.Pow(Radius, 3);

            return volume;
        }
    }
}
