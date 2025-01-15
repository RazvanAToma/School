using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_3
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

        float lightSpeed = 0.3f; // Lightspeed in Million km/s

        public double TravelTime()
        {
            double seconds = DistanceFromSun/lightSpeed;

            return seconds;
        }
    }
}
