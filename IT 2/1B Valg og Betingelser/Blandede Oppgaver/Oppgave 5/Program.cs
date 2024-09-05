
using System.Data;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 5");
Console.ResetColor();

Console.Write("Temperatur: ");
double temperature = double.Parse(Console.ReadLine());

Console.Write("Celsius eller Fahrenheit: ");
string degree = Console.ReadLine().ToUpper();
char degreeChar = degree[0];                                // First Letter, just in case


switch (degreeChar)
{
    case 'C':
        Console.WriteLine($"{temperature} Celsius er {temperature * 1.8 + 32} Fahrenheit");
        break;

    case 'F':
        Console.WriteLine($"{temperature} Fahrenheit is {(temperature - 32) * 5/9} Celsius");
        break;
}