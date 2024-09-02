
double avgSpeed = 50;       // km/h
       avgSpeed = 50 / 3.6; // m/s

double mainStraight = 100;  // m
double turnRadius = 31.83;  // m


double trackLength = (mainStraight * 2) + (2 * Math.PI * turnRadius); // m

Console.WriteLine($"Lengden på banen er {Math.Round(trackLength)} meter");


double timePerLap = trackLength / avgSpeed;

Console.WriteLine($"For 10 runder tar det syklisten {Math.Round(timePerLap * 10)} sekunder");