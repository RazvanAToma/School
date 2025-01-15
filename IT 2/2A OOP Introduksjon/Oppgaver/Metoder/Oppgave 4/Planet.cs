using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_4
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

        public string VolumeRatio(Planet comparedPlanet)
        {
            double objectVolume = (4 / 3) * Math.PI * Math.Pow(Radius, 3);
            double comparedVolume = (4 / 3) * Math.PI * Math.Pow(comparedPlanet.Radius, 3);

            if (objectVolume > comparedVolume)
            {
                return $"Det er plass til {objectVolume / comparedVolume} {comparedPlanet.Name} i {Name}";
            }
            else
            {
                return $"Det er plass til {comparedVolume / objectVolume} {Name} i {comparedPlanet.Name}";
            }
        }
    }
}
