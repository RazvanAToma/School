
// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

double Conversion(double c)
{
    return c * 9 / 5 + 32;
}

Console.WriteLine($"20 grader C er {Conversion(20)} grader F");



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

bool CheckPrime(int num)
{
    if (num > 0)
    {
        for (int i = 2; i < num; i += 1)
        {
            if (num % i == 0)
            {
                Console.WriteLine($"{num} er ikke et primtall");
                return false;
            }
        }

        Console.WriteLine($"{num} er et primtall");
        return true;
    }

    Console.WriteLine("Oppgi et gyldig tall...");
    return false;
}

CheckPrime(1);



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

List<int> nums = new List<int>();

while (true)
{
    Console.Write("Skriv inn et tall: ");
    string number = Console.ReadLine();
    
    if (number == "x")
    {
        break;
    }
    else
    {
        int nmbr = int.Parse(number);
        nums.Add(nmbr);
        Console.WriteLine($"Gjennomsnitter er naa {nums.Average()}");
    }
}



// Space
Console.WriteLine("\n");



// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

int mystiskFunksjon(int x)
{
    if (x == 0)
    {
        return 1;
    }
    else
    {
        return x * mystiskFunksjon(x - 1);
    }
}

Console.WriteLine(mystiskFunksjon(3));



// Space
Console.WriteLine("\n");



// Oppgave 5
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 5");
Console.ResetColor();

double pris(int billettPris, int antallBilletter)
{
    if (antallBilletter > 5)
    {
        return billettPris * antallBilletter * 0.9;
    }
    else
    {
        return billettPris * antallBilletter;
    }
}

double totalPris = pris(100, 6);
Console.WriteLine(totalPris); // Skal skrive ut 540



// Space
Console.WriteLine("\n");



// Oppgave 6
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 6");
Console.ResetColor();


