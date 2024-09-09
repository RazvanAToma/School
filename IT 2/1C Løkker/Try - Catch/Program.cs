
// Try / Catch
using System;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Try / Catch");
Console.ResetColor();

bool valid = false;
int num = 0;

while (!valid)
{
    Console.Write("Skriv inn et tall: ");

    try
    {
        num = int.Parse(Console.ReadLine());
        valid = true;
    }
    catch (FormatException exception)
    {
        string problem = exception.ToString();
        int cutOffIndex = problem.IndexOf("at System.Number");
        Console.WriteLine(problem.Substring(0, cutOffIndex));
        valid = false;
    }
}

Console.WriteLine(num);



// Space
Console.WriteLine("\n");



// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

valid = false;

while (!valid)
{
    Console.Write("Oppgi nummeret til måneden vi er i: ");
    int månednr;

    try
    {
        månednr = int.Parse(Console.ReadLine());

        if (månednr >= 1 && månednr <= 12)
        {
            Console.WriteLine($"Du skrev inn {månednr}.");
            valid = true;
        }
        else
        {
            Console.WriteLine("\nDu må oppgi et tall mellom 1 og 12.");
        }
    }
    catch (FormatException exception)
    {
        string problem = exception.ToString();
        int cutOffIndex = problem.IndexOf("at System.Number");
        Console.WriteLine(problem.Substring(0, cutOffIndex));
        valid = false;
    }
}
