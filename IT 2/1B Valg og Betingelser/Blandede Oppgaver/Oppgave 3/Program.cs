
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

int poengSum = 12;

if (poengSum <= 10)
{
    Console.WriteLine("Karakter 1");
}
else if (poengSum <= 20)
{
    Console.WriteLine("Karakter 2");
}



int tall1 = 5;
int tall2 = 10;
int antallPositive = 0;

if (tall1 > 0)
{
    antallPositive += 1;
}
else if (tall2 > 0)
{
    antallPositive += 1;
}

Console.WriteLine(antallPositive);