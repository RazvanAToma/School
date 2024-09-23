
// Oppgave 1
using System.ComponentModel.DataAnnotations;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ForegroundColor = ConsoleColor.White;

List<int> ints = new List<int>();

ints = Enumerable.Range(1, 50).ToList();

int max = 0;
int min = 0;

foreach (int num in ints)
{
    if      (num > max) { max = num; }
    else if (num < min) { min = num; }
}

Console.WriteLine($"{min}, {max}");



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

List<string> strings = new List<string> { "hallo", "a", "hei" };

string shortest = strings[0];
string longest = "";

foreach(string tekst in strings)
{
    if (tekst.Length > longest.Length)
    {
        longest = tekst;
    }
    else if (tekst.Length < shortest.Length)
    {
        shortest = tekst;
    }
}

Console.WriteLine(shortest);
Console.WriteLine(longest);



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

List<int> ints3 = new List<int> { 2, 3, 4, 5, -5, 8, 4, -7, 2, 9, 7, -9, 5, 3, 8, 5, -3, 3, 3, 2, 0, 1, 9, 1 } ;

int sum = 0;

foreach (int num in ints3)
{
    sum += num;
}

Console.WriteLine($"Summen av lista er {sum}, og gjennomsnittet er {sum / ints3.Count}");



// Space
Console.WriteLine("\n");



// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

List<int> ints4 = new List<int> { 1, 3, -2, 2, 5, -1, -7, 8, 5, 6, -4, 5 };

List<int> negatives = new List<int>();

foreach (int num in ints4)
{
    if (num < 0)
    {
        negatives.Add(num);
    }
}

foreach(int num in negatives)
{
    Console.WriteLine(num);
}

Console.WriteLine($"{negatives.Count}");



// Space
Console.WriteLine("\n");



// Oppgave 5
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 5");
Console.ResetColor();

List<int> ints5 = new List<int> { 3, 4, 1, 2, 5 };

List<int> sortedList = new List<int>();


while (ints5.Count > 0)
{
    int maxNum = 0;

    foreach (int num in ints5)
    {
        if (num > maxNum) { maxNum = num; }
    }

    ints5.Remove(maxNum);

    sortedList.Insert(0, maxNum);
}

foreach(int num in sortedList)
{
    Console.WriteLine(num);
}