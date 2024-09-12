

// Lage lister og hente ut enkeltverdier
using System;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Lage lister og hente ut enkeltverdier");
Console.ResetColor();

// Array
string[] biler = { "Volvo", "Tesla", "Skoda", "Ford" };

// Lage en liste med verdier fra array
List<string> bilerListe = new List<string>(biler); // Biler, er hva som skal ligge i lista, man kan skrive tall også


// Hente ut verdier
int[] tall = { 1, 3, 4, 12, 6, 9 };
List<int> tallListe = new List<int>(tall);

Console.WriteLine(tall[0]);
Console.WriteLine(tallListe[0]);
Console.WriteLine(tall[3]);
Console.WriteLine(tallListe[3]);



// Space
Console.WriteLine("\n");



// Fylle lister med tallverdier
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Fylle lister med tallverdier");
Console.ResetColor();

// Liste som inneholder tallene 1 - 5
List<int> nyTallListe = new List<int>();

nyTallListe = Enumerable.Range(1, 5).ToList();

Console.WriteLine(nyTallListe[0]);
Console.WriteLine(nyTallListe[1]);
Console.WriteLine(nyTallListe[2]);
Console.WriteLine(nyTallListe[3]);
Console.WriteLine(nyTallListe[4] + "\n");


// Legge til verdier med .Add()
List<int> endaEnListe = new List<int>();

for (int i = 2; i < 12; i += 1)
{
    endaEnListe.Add(2 * i);
}

// Printe liste
Console.Write("[");
foreach (int num in endaEnListe)
{
    Console.Write($" {num},");
}
Console.WriteLine("]");



// Space
Console.WriteLine("\n");




// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

string[] verdensDelerArr = { "Europe", "North-America", "South-America", "Asia", "Africa", "Oceania", "Antarctica" };
List<string> verdensDeler = new List<string>(verdensDelerArr);

Console.WriteLine(verdensDeler[0]);
Console.WriteLine(verdensDeler[3]);
Console.WriteLine(verdensDeler[verdensDeler.Count - 1]);



// Space
Console.WriteLine("\n");




// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

List<int> oneToFifty = new List<int>();

oneToFifty = Enumerable.Range(1, 50).ToList();

foreach (int num in oneToFifty)
{
    Console.Write(num);
    Console.Write(" ");
}

Console.WriteLine("\n");



// Space
Console.WriteLine("\n");




// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

List<int> firstHundredOdd = new List<int>();

for (int i = 1; i < 100; i += 2)
{
    firstHundredOdd.Add(i);
}

foreach(int odd in firstHundredOdd)
{
    Console.Write(odd);
    Console.Write(" ");
}
Console.WriteLine("\n");



// Space
Console.WriteLine("\n");




// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

List<double> firstTwentySquared = new List<double>();

for (int i = 1; i < 20 + 1; i += 1)
{
    firstTwentySquared.Add(Math.Pow(i, 2));
}

foreach (double squared in firstTwentySquared)
{
    Console.Write(squared);
    Console.Write(" ");
}
Console.WriteLine("\n");



// Space
Console.WriteLine("\n");




// Oppgave 5
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 5");
Console.ResetColor();

List<double> firstFifteenCubed= new List<double>();

for (int i = 1; i < 15 + 1; i += 1)
{
    firstFifteenCubed.Add(Math.Pow(i, 3));
}

foreach (double cubed in firstFifteenCubed)
{
    Console.Write(cubed);
    Console.Write(" ");
}
Console.WriteLine("\n");