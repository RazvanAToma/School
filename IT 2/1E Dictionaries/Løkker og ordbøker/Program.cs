
// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

Dictionary<string, int> countries = new Dictionary<string, int>
{
    { "India",      1450935791},
    { "China",      1419321278},
    { "USA",        345426571 },
    { "Indonesia",  283487931 },
    { "Pakistan",   251269164 },
};



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

foreach (string country in countries.Keys)
{
    Console.WriteLine(country);
}



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

foreach(int population in countries.Values)
{
    Console.WriteLine(population);
}



// Space
Console.WriteLine("\n");



// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

foreach (KeyValuePair<string, int> kvp in countries)
{
    Console.WriteLine($"{kvp.Key} har {kvp.Value} innbyggere");
}