
// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

Console.Write("Tall 1: ");
double tall1 = double.Parse(Console.ReadLine());

Console.Write("Tall 2: ");
double tall2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Summen av {tall1} og {tall2} er {tall1 + tall2}");



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

Console.Write("Antall Liter: ");
double liter = double.Parse(Console.ReadLine());

Console.WriteLine($"{liter}L i dL er {liter * 10}");



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

Console.Write("Grader F: ");
double degreesF = double.Parse(Console.ReadLine());

double degreesC = (degreesF - 32) * 5 / 9;

Console.WriteLine($"{degreesF} fahrenheit til celius er {degreesC}");



// Space
Console.WriteLine("\n");



// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

Console.Write("Antall Minutter: ");
int minutter = int.Parse(Console.ReadLine());


if (minutter / 60 > 0)
{
    Console.WriteLine($"{minutter} minutter er {minutter / 60} time(r) og {minutter % 60} minutter");
}
else
{
    Console.WriteLine($"{minutter} minutter er under 1 time");
}