
// Redigere Lister 
using System.Diagnostics;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Redigere Lister");
Console.ResetColor();

// Legge til verdier
List<string> tegneseriefigurer = new List<string>();

tegneseriefigurer.Add("Donald Duck");
tegneseriefigurer.Add("Pondus");
tegneseriefigurer.Add("Obelix");


// "Inject"
tegneseriefigurer.Insert(1, "Asterix");


// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();


List<int> ints = new List<int>(Enumerable.Range(1, 20).ToList());

for (int i = 0; i < ints.Count; i += 1)
{
    if (ints[i] % 2 == 0)
    {
        ints.RemoveAt(i);
    }
}



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

List<int> ints2 = new List<int>([1, 6, 3, 4, 2, 3, 5, 7, 8, 3, 3, 3, 2, 3, 4, 6, 7, 3, 4, 3, 3]);

while (ints2.Contains(3))
{
    ints2.Remove(3);
}

foreach(int num in ints2)
{
    Console.WriteLine(num);
}



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

List<int> ints3a = new List<int>();
List<int> ints3b = new List<int>();
List<int> ints3c = new List<int>();

for (int i = 0; i < 20 + 1; i += 2)
{
    ints3a.Add(i);
}

for (int i = 0; i < 10 + 1; i += 1)
{
    ints3b.Add(0);
}

for (int i = 0; i < 10; i += 1)
{
    if (i % 2 == 0)
    {
        ints3c.Add(0);
    }
    else
    {
        ints3c.Add(1);
    }
}

foreach (int num in ints3c)
{
    Console.WriteLine(num);
}



// Space
Console.WriteLine("\n");



// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

List<string> byer = new List<string>(["OSLOO", "Trondheim", "Bergen", "Stavaangir", "Kristiansand", "Drammen", "Tromsø"]);

int stavangerIndex = byer.IndexOf("Stavaangir");

byer.Remove("Stavaangir");


int osloIndex = byer.IndexOf("OSLOO");

byer.RemoveAt(osloIndex);


byer.Insert(stavangerIndex, "Stavanger");
byer.Insert(osloIndex, "Oslo");

foreach (string by in byer)
{
    Console.WriteLine(by);
}



// Space
Console.WriteLine("\n");



// Oppgave 6
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 6");
Console.ResetColor();

List<int> ints6 = new List<int>([0, 1, 2, 0, 0, 3, 4, 5, 0, 0, 6, 0, 7, 0, 8, 0, 0, 0, 9, 10]);

while (ints6.Contains(0))
{
    ints6.Remove(0);
}

foreach (int num in ints6)
{
    Console.WriteLine(num);
}



// Space
Console.WriteLine("\n");



// Oppgave 7
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 7");
Console.ResetColor();

List<string> names = new List<string> { "Anne", "Per", "Ole", "Anne", "Lise", "Ole", "Anne", "Per", "Anne", "Tor", "Ole" };

List<string> uniques = new List<string>();

foreach (string name in names)
{
    if (!uniques.Contains(name))
    {
        uniques.Add(name);
    }
}

names = uniques;

foreach(string name in names)
{
    Console.WriteLine(name);
}



// Space
Console.WriteLine("\n");



// Oppgave 8
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 8");
Console.ResetColor();

Random rnd = new Random();

List<int> random = new List<int>();

for (int i = 0; i < 1000; i += 1)
{
    random.Add(rnd.Next(1, 100));
}

random.Sort();

Console.WriteLine(random[0]);
Console.WriteLine(random.Last());



// Space
Console.WriteLine("\n");



// Oppgave 9
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 9");
Console.ResetColor();

random.Insert(random.LastIndexOf(16) + 1, 17);
random.Insert(random.LastIndexOf(41) + 1, 42);
random.Insert(random.LastIndexOf(80) + 1, 81);

foreach(int num in random)
{
    Console.WriteLine(num);
}