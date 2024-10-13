

// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

void KvadratAreal(double sideLengde)
{
    Console.WriteLine($"Arealet av et kvadrat med sidelengde {sideLengde} er {Math.Pow(sideLengde, 2)}");
}

KvadratAreal(2);



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

void SirkelAreal(double radius)
{
    const double pi = Math.PI;

    Console.WriteLine($"En sirkel med radius {radius}, har areal {Math.Round(pi * Math.Pow(radius, 2), 2)}");
}

SirkelAreal(2);



// Space
Console.WriteLine("\n");




// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

void ByOgLand(string by, string land)
{
    Console.WriteLine($"{by} er en by i {land}");
}

ByOgLand("Oslo", "Norge");



// Space
Console.WriteLine("\n");



// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

void Minst(int a, int b)
{
    if (a < b)
    {
        Console.WriteLine($"{a} er minst");
    }
    else
    {
        Console.WriteLine($"{b} er minst");
    }
}

Minst(1, 2);



// Space
Console.WriteLine("\n");




// Oppgave 5
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 5");
Console.ResetColor();

void NavneSkilt(string navn)
{
    int nameLength = navn.Length;

    Console.Write("+");
    for (int i = -2; i != nameLength; i += 1)
    {
        Console.Write("-");
    }
    Console.WriteLine("+");

    Console.Write("|");
    Console.Write($" {navn} ");
    Console.WriteLine("|");

    Console.Write("+");
    for (int i = -2; i < nameLength; i += 1)
    {
        Console.Write("-");
    }
    Console.WriteLine("+");
}

NavneSkilt("Demetrius Demarcus Bartholomew James The Third");



// Space
Console.WriteLine("\n");




// Oppgave 6
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 6");
Console.ResetColor();

void PrintList(List<int> list)
{
    for (int i = 0; i < list.Count; i += 1)
    {
        Console.WriteLine($"{i}:\t{list[i]}");
    }
}

List<int> numbers = new List<int>([1, 2, 4, 3, 1, 5, 17, 1, 53, 1, 6, 13, 7, 41, 6, 14, 631, 6, 16, 1, 3, 6, 42, 714]);

PrintList(numbers);



// Space
Console.WriteLine("\n");




// Oppgave 7
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 7");
Console.ResetColor();

void PrintDict(Dictionary<string, int> dict)
{
    Console.WriteLine($"Navn: \t Alder:");
    foreach (KeyValuePair<string, int> pair in dict)
    {
        Console.WriteLine($"{pair.Key}: \t {pair.Value}");
    }
}

Dictionary<string, int> people = new Dictionary<string, int>
{
    { "Jonn", 85 },
    { "Alex", 192},
    { "Razv", 291 }
};

PrintDict(people);