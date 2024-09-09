// For-Løkker
using System.Runtime.ExceptionServices;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("For-Løkker");
Console.ResetColor();

for (int i = 0; i < 10; i+= 1)
{
    Console.WriteLine(i);
}



// Space
Console.WriteLine("\n");



// Oppgave 1.1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1.1");
Console.ResetColor();

for (int i = 1; i < 30 + 1; i += 1)
{
    Console.WriteLine(i);
}



// Space
Console.WriteLine("\n");



// Oppgave 1.2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1.2");
Console.ResetColor();

for (int i = 1; i < 100 + 1; i += 1)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }  
}



// Space
Console.WriteLine("\n");



// Oppgave 1.3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1.3");
Console.ResetColor();

for (int i = 5; i < 50 + 1; i += 1)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}



// Space
Console.WriteLine("\n");



// Oppgave 1.4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1.4");
Console.ResetColor();

for (int i = 21; i < 42 + 1; i += 7)
{
    Console.WriteLine(i);
}



// Space
Console.WriteLine("\n");



// Oppgave 1.5
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1.5");
Console.ResetColor();

for (int i = 100; i > 0; i -= 10)
{
    Console.WriteLine(i);
}



// Space
Console.WriteLine("/n");



// For-Løkker og Tekst
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("For-Løkker og Tekst");
Console.ResetColor();

string tekst = "Programmering!";

for (int i = 0; i < tekst.Length; i += 1)
{
    Console.WriteLine(tekst[i]);
}



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

Console.Write("Skriv inn noe: ");
string userInput = Console.ReadLine();

for (int i = 0; i < userInput.Length; i += 1)
{
    Console.WriteLine(userInput[i]);
}



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

int n = 50;

for (int i = 0; i < n + 1; i += 1)
{
    Console.WriteLine($"Denne løkka har gjentatt seg {i} ganger.");
}