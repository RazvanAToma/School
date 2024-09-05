
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.WriteLine("1.");
Console.ResetColor();


Console.Write("Skriv inn et tall: ");
int tall1 = int.Parse(Console.ReadLine());

Console.Write("Skriv inn enda et tall: ");
int tall2 = int.Parse(Console.ReadLine());

Console.Write("Skriv inn ENDA et tall: ");
int tall3 = int.Parse(Console.ReadLine());


if ((tall1 + tall2 + tall3)/3 == tall1)
{
    Console.WriteLine("Alle tallene er like");
}
else
{
    Console.WriteLine("Tallene er ikke like");
}



// Space
Console.WriteLine("\n");



Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2.");
Console.ResetColor();

Console.Write("Skriv inn et heltall: ");
int userInt = int.Parse(Console.ReadLine());

if (userInt % 2 == 0)
{
    Console.WriteLine($"{userInt} er et Partall");
}
else
{
    Console.WriteLine($"{userInt} er et Oddetall");
}



// Space
Console.WriteLine("\n");



Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("3.");
Console.ResetColor();

Console.Write("Skriv inn et tall: ");
int lastNum1 = int.Parse(Console.ReadLine());

Console.Write("Skriv inn enda et tall: ");
int lastNum2 = int.Parse(Console.ReadLine());

Console.Write("Skriv inn ENDA et tall: ");
int lastNum3 = int.Parse(Console.ReadLine());


if (lastNum1 > lastNum2 && lastNum1 > lastNum3)
{
    Console.WriteLine($"{lastNum1} er det storste tallet");
}
else if (lastNum2 > lastNum1 && lastNum2 > lastNum3)
{
    Console.WriteLine($"{lastNum2} er det storste tallet");
}
else
{
    Console.WriteLine($"{lastNum3} er det storste tallet");
}