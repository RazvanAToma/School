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
        public float DistanceFromSun { get; set; }
        public float Radius { get; set; }

        public Planet(string name, float distanceFromSun, float radius)
        {
            Name = name;
            DistanceFromSun = distanceFromSun;
            Radius = radius;
        }

        public double Surface()
        {
            double surface = 4 * Math.PI * Math.Pow(Radius, 2);

            return surface;
        }
    }
}
