
// Gjennomsnitt
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Gjennomsnitt");
Console.ResetColor();

int n = 10;
int total = 0;

for (int i = 1; i < n + 1; i++)
{
    total += i;
}

double gjennomsnitt = (double)total / n;

Console.WriteLine($"Summen av tallene fra og med 1 til og med {n} er {total}.");
Console.WriteLine($"Gjennomsnittet er {gjennomsnitt}.");



// Space
Console.WriteLine("\n");



// Nøstede Løkker
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Nøstede Løkker");
Console.ResetColor();

for (int i = 1; i < 5; i++)
{
    for (int j = 1; j < 5; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.Write("\n");
}



// Space
Console.WriteLine("\n");



// Oppgave 7
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 7");
Console.ResetColor();

n = 100;
total = 0;

for (int i = 0; i < n + 1; i += 1)
{
    total += i;

    gjennomsnitt = (double)total / n;
}

Console.WriteLine($"Sum: {total}\nGjennomsnitt: {gjennomsnitt}");



// Space
Console.WriteLine("\n");



// Oppgave 8
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 8");
Console.ResetColor();

n = 75;
total = 0;

for (int i = 50; i < n + 1; i += 1)
{
    total += i;

    gjennomsnitt = (double)total / n;
}

Console.WriteLine($"Sum: {total}\nGjennomsnitt: {gjennomsnitt}");



// Space
Console.WriteLine("\n");



// Oppgave 9
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 9");
Console.ResetColor();

n = 10;

for (int tall1 = 1; tall1 < n + 1; tall1 += 1)
{
    Console.Write($"{tall1}\t|\t"); // First letters on the left, to indicate which row it is

    for (int tall2 = 1; tall2 < n + 1; tall2 += 1)
    {
        Console.Write($"{tall2 * tall1}\t"); // Makes the row
    }

    Console.Write("\n");

    // Adds lines inbetween the rows.
    for (int i = 0; i < n; i += 1)
    {
        Console.Write("---------");
    }
    Console.WriteLine("---------");
}



// Space
Console.WriteLine("\n");



// Oppgave 10
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 10");
Console.ResetColor();

n = 4;

for (int i = 0; i < n; i += 1)
{
    for (int a = 0; a < n; a += 1)
    {
        Console.Write("#");
    }

    Console.WriteLine("");
}