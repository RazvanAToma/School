
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("If-setninger");
Console.ResetColor();

Console.Write("Skriv inn et heltall: ");
int tall = int.Parse(Console.ReadLine());

if (tall > 10)
{
    Console.WriteLine("Tallet er storre enn 10");
}
else if (tall < 10)
{
    Console.WriteLine("Tallet er mindre enn 10");
}
else
{
    Console.WriteLine("Tallet er 10");
}



// Space
Console.WriteLine("\n");



// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

Console.Write("Skriv inn et heltall: ");
int num1 = int.Parse(Console.ReadLine());

if (num1 < 0)
{
    Console.WriteLine("Tallet er negativt");
}
else if (num1 > 0)
{
    Console.WriteLine("Tallet er positivt");
}
else
{
    Console.WriteLine("Tallet er 0");
}



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

Console.Write("Skriv inn et positivt heltall: ");
int num2 = int.Parse(Console.ReadLine());

if (num2 > 0 && num2 < 9)
{
    Console.WriteLine("Tallet er ensifret");
}
else if (num2 > 9 && num2 < 99)
{
    Console.WriteLine("Tallet er tosifret");
}
else if (num2 > 99 && num2 < 999)
{
    Console.WriteLine("Tallet er tresifret");
}
else if (num2 > 999 && num2 < 9999)
{
    Console.WriteLine("Tallet er firesifret");
}
else
{
    Console.WriteLine("Tallet er mer enn firesifret");
}



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

Console.Write("Skriv inn et heltall: ");
int num3  = int.Parse(Console.ReadLine());

if (num3 > 50 && num3 < 100)
{
    Console.WriteLine("Tallet er mellom 50 og 100");
}