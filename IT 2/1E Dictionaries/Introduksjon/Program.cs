
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Dictionaries");
Console.ResetColor();


// Definere
Dictionary<string, string> person = new Dictionary<string, string>
{
    { "fornavn", "Per" },
    { "etternavn", "Hansen" }
};


// Hente ut
Console.WriteLine($"{person["fornavn"]} {person["etternavn"]}");


// Legge til nye nøkler og verdier
person.Add("hjemby", "Drammen");
// Eller
person["yrke"] = "Lege";


// Endre eller slette
person["hjemby"] = "Oslo";

person.Remove("yrke");



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

Dictionary<string, string> meg = new Dictionary<string, string> { };

meg.Add("fornavn", "Razvan");
meg.Add("etternavn", "Toma");

foreach(KeyValuePair<string, string> entry in meg)
{
    Console.WriteLine($"{entry.Key.ToUpper()}et ditt er {entry.Value}");
}




// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

Dictionary<int, string> tall = new Dictionary<int, string>
{
    { 1, "en"},
    { 2, "to"},
    { 3, "tre"},
    { 4, "fire"},
    { 5, "fem"},
    { 6, "seks"},
    { 7, "sju"},
    { 8, "atte"},
    { 9, "ni"},
    { 10, "ti"},
};

foreach(KeyValuePair<int, string> entry in tall)
{
    Console.WriteLine($"{entry.Key}\t=\t{entry.Value}");
}



// Space
Console.WriteLine("\n");



// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

Dictionary<char, char> encryption = new Dictionary<char, char>
{
    {'a', 'c' },
    {'b', 'd' },
    {'c', 'e' },
    {'d', 'f' },
    {'e', 'g' },
    {'f', 'h' },
    {'g', 'i' },
    {'h', 'j' },
    {'i', 'k' },
    {'j', 'l' },
    {'k', 'm' },
    {'l', 'n' },
    {'m', 'o' },
    {'n', 'p' },
    {'o', 'q' },
    {'p', 'r' },
    {'q', 's' },
    {'r', 't' },
    {'s', 'u' },
    {'t', 'v' },
    {'u', 'w' },
    {'v', 'x' },
    {'w', 'y' },
    {'x', 'z' },
    {'y', 'a' },
    {'z', 'b' },
};

string text = "Hei";
List<char> encrypted = new List<char>();
List<char> decrypted = new List<char>();

foreach (char letter in text.ToLower())
{
    encrypted.Add(encryption[letter]);
}

foreach(char letter in encrypted)
{
    Console.Write(letter);
}