
// Biblioteket Random

// Definere random
Random random = new Random();

// Tilfeldig heltall fra 0 til (men ikke med) 5:
random.Next(0, 5);

// Tilfeldig desimaltall mellom 0 og 1:
random.NextDouble();



// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

Console.WriteLine("Kaster terning...");

int terningSider = 6;

int terningKast = random.Next(1, terningSider + 1);

Console.WriteLine(terningKast);



// Space
Console.WriteLine("\n");



// Oppgave 5
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 5");
Console.ResetColor();

Console.WriteLine("Kaster to terninger...");

int sum = 0;

terningKast = random.Next(1, terningSider + 1);
sum += terningKast;

terningKast = random.Next(1, terningSider + 1);
sum += terningKast;

Console.WriteLine(sum);



// Space
Console.WriteLine("\n");



// Oppgave 6
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 6");
Console.ResetColor();

Console.Write("Antall terninger:");
int antallTerninger = int.Parse(Console.ReadLine());

sum = 0;

for (int i = 0; i < antallTerninger; i += 1)
{
    terningKast = random.Next(1, terningSider + 1);
    Console.WriteLine(terningKast);
    sum += terningKast;
}

Console.WriteLine($"Summen av {antallTerninger} terningkast er {sum}");



// Space
Console.WriteLine("\n");



// Oppgave 7
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 7");
Console.ResetColor();

double number = random.NextSingle() + random.Next(0, 6);

Console.WriteLine(number);