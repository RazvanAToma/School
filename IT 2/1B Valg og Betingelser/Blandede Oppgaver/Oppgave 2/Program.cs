
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

Console.Write("Skriv inn poengsum: ");
int poengSum = int.Parse(Console.ReadLine());

if (poengSum <= 20)
{
    Console.WriteLine("Karakter 1");
}
else if (poengSum <= 40)
{
    Console.WriteLine("Karakter 2");
}
else if (poengSum <= 60)
{
    Console.WriteLine("Karakter 3");
}
else if (poengSum <= 80)
{
    Console.WriteLine("Karakter 4");
}
else if (poengSum <= 90)
{
    Console.WriteLine("Karakter 5");
}
else if (poengSum <= 100)
{
    Console.WriteLine("Karakter 6");
}
else
{
    Console.WriteLine("Umulig poengsum");
}