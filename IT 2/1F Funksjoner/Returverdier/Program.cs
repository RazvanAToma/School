
// Oppgave 1
using System;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

double TrekantAreal(double height, double lenght)
{
    double areal = (height * lenght)/2;

    return areal;
}


Console.WriteLine(TrekantAreal(5, 5));



// Space
Console.WriteLine("\n");




// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

string tekst = "lkjbsljakbd;lkjaslkjbdslkjsa;lkjbd;lkas;lkbf;lkjadslkjbd";

int Count(string tekst, char character)
{
    int count = 0;

    foreach (char thing in tekst)
    {
        if (thing == character)
        {
            count += 1;
        }
    }

    return count;
}

Console.WriteLine(Count(tekst, ';'));



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

tekst = "A path from a point approximately 330 metres east of the most south westerly corner of 17 Batherton Close, Widnes and approximately 208 metres east-south-east of the most southerly corner of Unit 3 Foundry Industrial Estate, Victoria Street, Widnes, proceeding in a generally east-north-easterly direction for approximately 28 metres to a point approximately 202 metres east-south-east of the most south-easterly corner of Unit 4 Foundry Industrial Estate, Victoria Street, and approximately 347 metres east of the most south-easterly corner of 17 Batherton Close, then proceeding in a generally northerly direction for approximately 21 metres to a point approximately 210 metres east of the most south-easterly corner of Unit 5 Foundry Industrial Estate, Victoria Street, and approximately 202 metres east-south-east of the most north-easterly corner of Unit 4 Foundry Industrial Estate, Victoria Street, then proceeding in a generally east-north-east direction for approximately 64 metres to a point approximately 282 metres east-south-east of the most easterly corner of Unit 2 Foundry Industrial Estate, Victoria Street, Widnes and approximately 259 metres east of the most southerly corner of Unit 4 Foundry Industrial Estate, Victoria Street, then proceeding in a generally east-north-east direction for approximately 350 metres to a point approximately 3 metres west-north-west of the most north westerly corner of the boundary fence of the scrap metal yard on the south side of Cornubia Road, Widnes, and approximately 47 metres west-south-west of the stub end of Cornubia Road be diverted to a 3 metre wide path from a point approximately 183 metres east-south-east of the most easterly corner of Unit 5 Foundry Industrial Estate, Victoria Street and approximately 272 metres east of the most north-easterly corner of 26 Ann Street West, Widnes, then proceeding in a generally north easterly direction for approximately 58 metres to a point approximately 216 metres east-south-east of the most easterly corner of Unit 4 Foundry Industrial Estate, Victoria Street and approximately 221 metres east of the most southerly corner of Unit 5 Foundry Industrial Estate, Victoria Street, then proceeding in a generally easterly direction for approximately 45 metres to a point approximately 265 metres east-south-east of the most north-easterly corner of Unit 3 Foundry Industrial Estate, Victoria Street and approximately 265 metres east of the most southerly corner of Unit 5 Foundry Industrial Estate, Victoria Street, then proceeding in a generally east-south-east direction for approximately 102 metres to a point approximately 366 metres east-south-east of the most easterly corner of Unit 3 Foundry Industrial Estate, Victoria Street and approximately 463 metres east of the most north easterly corner of 22 Ann Street West, Widnes, then proceeding in a generally north-north-easterly direction for approximately 19 metres to a point approximately 368 metres east-south-east of the most easterly corner of Unit 3 Foundry Industrial Estate, Victoria Street and approximately 512 metres east of the most south easterly corner of 17 Batherton Close, Widnes then proceeding in a generally east-south, easterly direction for approximately 16 metres to a point approximately 420 metres east-south-east of the most southerly corner of Unit 2 Foundry Industrial Estate, Victoria Street and approximately 533 metres east of the most south-easterly corner of 17 Batherton Close, then proceeding in a generally east-north-easterly direction for approximately 240 metres to a point approximately 606 metres east of the most northerly corner of Unit 4 Foundry Industrial Estate, Victoria Street and approximately 23 metres south of the most south westerly corner of the boundary fencing of the scrap metal yard on the south side of Cornubia Road, Widnes, then proceeding in a generally northern direction for approximately 44 metres to a point approximately 3 metres west-north-west of the most north westerly corner of the boundary fence of the scrap metal yard on the south side of Cornubia Road and approximately 47 metres west-south-west of the stub end of Cornubia Road.";

int CountWords(string tekst)
{
    int count = 0;

    foreach(char character in tekst)
    {
        if (character == ' ')
        {
            count += 1;
        }
    }

    return count;
}

Console.WriteLine(CountWords(tekst) + 1);



// Space
Console.WriteLine("\n");




// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

int Biggest(int a, int b, int c)
{
    List<int> ints = new List<int>([a, b, c]);

    return ints.Max();
}

int Smallest(int a, int b, int c)
{
    List<int> ints = new List<int>([a, b, c]);

    return ints.Min();
}

Console.WriteLine(Biggest(1, 5, 1));
Console.WriteLine(Smallest(5, 1, 4));



// Space
Console.WriteLine("\n");




// Oppgave 5
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 5");
Console.ResetColor();

bool IsEqual(int a, int b, int c)
{
    if (a == b && a == c)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine(IsEqual(1, 2, 1));



// Space
Console.WriteLine("\n");




// Oppgave 6
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 6");
Console.ResetColor();

List<int> numbers = new List<int>([1, 2, 3, 4, 5, 6, 7, 8, 9]);

List<int> Double(List<int> list)
{
    List<int> doubled = new List<int>();

    foreach (int i in list)
    {
        doubled.Add(i * 2);
    }
    return doubled;
}

Double(numbers);

Console.WriteLine("\n");

foreach (int i in numbers)
{
    Console.Write($"{i}, ");
}

Console.WriteLine("\n");

foreach (int i in Double(numbers))
{
    Console.Write($"{i}, ");
}