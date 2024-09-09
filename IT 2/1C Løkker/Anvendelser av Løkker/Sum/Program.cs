
// Sum
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Sum");
Console.ResetColor();

int total = 0;

for (int i = 0; i < 10; i += 1)
{
    total += i;
}

Console.WriteLine(total);



// Space
Console.WriteLine("\n");



// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

total = 0;

for (int i = 1; i < 10 + 1; i += 1)
{
    total += i;
}

Console.WriteLine(total);



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

total = 0;

for (int i = 1; i < 100 + 1; i += 1)
{
    total += i;
}

Console.WriteLine(total);



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

total = 0;
int index = 1;

while (index < 100 + 1)
{
    total += index;
    index += 1;
}

Console.WriteLine(total);



// Space
Console.WriteLine("\n");



// Oppgave 6
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 6");
Console.ResetColor();

Console.Write("Hvor mange tall vil du summere: ");
int amount = int.Parse(Console.ReadLine());

index = 1;

total = 0;

while (index < amount + 1)
{
    Console.Write($"Tall {index}: ");

    total += int.Parse(Console.ReadLine());

    index += 1;
}

Console.WriteLine($"Summen av tallene er {total}");