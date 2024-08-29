
double radius = 4;          // cm

double coneHeight = 5;      // cm

double cylinderHeight = 6.28;  // cm


double volumeCone = (Math.PI * Math.Pow(radius, 2) * coneHeight) / 3;
double volumeCylinder = (Math.PI * Math.Pow(radius, 2) * cylinderHeight);
double volumeSphere = ((4 / 3) * (Math.PI * Math.Pow(radius, 3))) / 2;

double volumeBottle = volumeCone + volumeCylinder + volumeSphere;

Console.WriteLine($"En flaske bygd opp av en kule med radius {radius}, " +
                  $"en kjegle med hoyde {coneHeight}, " +
                  $"og en sylinder med hoyde {cylinderHeight} " +
                  $"gir et volum paa {Math.Round(volumeBottle) / 1000} L");