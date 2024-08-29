
// Biblioteket Math

// PI
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("PI");
Console.ResetColor();

double pi = Math.PI;
Console.WriteLine(pi);



// Kvadratrot
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nKvadratrot");
Console.ResetColor();

double a = 100;
double b = Math.Sqrt(a);
Console.WriteLine(b);



// Areal Sirkel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nAreal Sirkel, med radius 3");
Console.ResetColor();

double radiusEksempel = 3;
double arealEksempel = Math.PI * Math.Pow(radiusEksempel, 2);

Console.WriteLine(arealEksempel);



// Space
Console.WriteLine("\n");



// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

Console.Write("Sirkelradius: ");
double radius = double.Parse(Console.ReadLine());

double omkrets = 2 * Math.PI * radius;
double areal = Math.PI * Math.Pow(radius, 2);


Console.WriteLine($"En sirkel med radius {radius}, har omkrets {omkrets} og areal {areal}");



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

Console.Write("Katet 1: ");
double katet1 = double.Parse(Console.ReadLine());

Console.Write("Katet 2: ");
double katet2 = double.Parse(Console.ReadLine());

double hypotenus = Math.Sqrt(Math.Pow(katet1, 2) + Math.Pow(katet2, 2));

Console.WriteLine($"For en rettvinklet trekant med katet1 {katet1} og katet2 {katet2}, er hypotenusen {hypotenus}");



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

double cosAngle = Math.Cos(60 * Math.PI/180);

int hosKatet = 7;

hypotenus = hosKatet / cosAngle;

Console.WriteLine(Math.Round(hypotenus, 2));