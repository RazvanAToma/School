// While-Løkker
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("While-Løkker");
Console.ResetColor();

int x = 0;

while (x < 10)
{
    Console.WriteLine(x);
    x += 1;
}



// Space
Console.WriteLine("\n");



// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

x = 0;

while (x < 10)
{
    x += 1;
    Console.WriteLine(x);
}



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

x = 5;

while (x < 30 + 1)
{
    Console.WriteLine(x);
    x += 1;
}



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

/* x blir satt til 1
 * x vil bli mindre og mindre
 * Løkka vil kjøre uendelig
*/



// Space
Console.WriteLine("\n");



// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

/* x blir satt til 1
 * x økes med 10 hver gang
 * løkka sjekker om x er forksjellig fra 100
 * x vil aldri bli hundre nøyaktig
 * Dermed vil løkke kjøre uendelig
*/



// Space
Console.WriteLine("\n");



// Oppgave 5
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 5");
Console.ResetColor();

int index = 0;

while (index < 100)
{
    index += 1;
    Console.WriteLine(Math.Pow(index, 2));
}



// Space
Console.WriteLine("\n");



// Løkker og tilfeldige tall
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Løkker og tilfeldige tall");
Console.ResetColor();

int total = 0;
Random rnd = new Random();

while (total < 10)
{
    int terning1 = rnd.Next(1, 7);
    int terning2 = rnd.Next(1, 7);

    total = terning1 + terning2;

    Console.WriteLine($"Terningene viser {terning1} og {terning2}. Summen er {total}.");
}



// Space
Console.WriteLine("\n");



// Oppgave 7
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 7");
Console.ResetColor();

while (total != 12)
{
    int terning1 = rnd.Next(1, 7);
    int terning2 = rnd.Next(1, 7);

    total = terning1 + terning2;

    Console.WriteLine($"Terningene viser {terning1} og {terning2}. Summen er {total}.");
}



// Space
Console.WriteLine("\n");



// Oppgave 8
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 8");
Console.ResetColor();

while (total != 7)
{
    int terning1 = rnd.Next(1, 7);
    int terning2 = rnd.Next(1, 7);

    total = terning1 + terning2;

    Console.WriteLine($"Terningene viser {terning1} og {terning2}. Summen er {total}.");
}