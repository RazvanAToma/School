
using ScottPlot;

// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

Console.Write("Hva er radius til kulen? ");
int r = int.Parse(Console.ReadLine());

double volumKule = (4 * Math.PI * Math.Pow(r, 3)) / 3;

Console.WriteLine($"Volum til kula er {Math.Round(volumKule, 2)}");



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

for (int i = 2; i < 50 + 1; i += 2)
{
    Console.WriteLine(i);
}



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

Console.Write("Skriv inn et tall: ");
int tall = int.Parse(Console.ReadLine());

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

CheckPrime(tall);




// Space
Console.WriteLine("\n");



// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

Console.Write("Fornavn: ");
string fornavn = Console.ReadLine();

Console.Write("Etternavn: ");
string etternavn = Console.ReadLine();

Console.WriteLine($"{etternavn}, {fornavn} - {fornavn[0].ToString().ToUpper()}, {etternavn[0].ToString().ToUpper()}");



// Space
Console.WriteLine("\n");



// Oppgave 5
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 5");
Console.ResetColor();

Dictionary<string, double> handlekurv = new Dictionary<string, double> {
  {"melk", 17.90},
  {"smør", 38.90},
  {"kokt skinke", 23.10},
  {"sjokolade", 11.90},
  {"oppvaskmiddel", 24.40},
  {"frossenpizza", 29.90}
};



// a)

double min = 10000;
string minItem = "";

foreach (KeyValuePair<string, double> pair in handlekurv)
{
    if (pair.Value < min)
    {
        min = pair.Value;
        minItem = pair.Key;
    }
}

Console.WriteLine($"Laveste pris i handlevognen er {min:f2}, som er {minItem}");

// b)

double max = 0;
string maxItem = "";

foreach (KeyValuePair<string, double> pair in handlekurv)
{
    if (pair.Value > max)
    {
        max = pair.Value;
        maxItem = pair.Key;
    }
}

Console.WriteLine($"Laveste pris i handlevognen er {max:f2}, som er {maxItem}");



// c)

double sum = 0;

foreach (double d in handlekurv.Values)
{
    sum += d;
}

Console.WriteLine($"Summen av varene er {sum:f2}");



// Space
Console.WriteLine("\n");



// Oppgave 6
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 6");
Console.ResetColor();

Random rnd = new Random();

List<int> lottoTall = new List<int>();

List<int> Lotto()
{
    while (true)
    {
        int nextInt = rnd.Next(1, 35);

        if (lottoTall.Count == 7)
        {
            return lottoTall;
        }
        else if (!lottoTall.Contains(nextInt))
        {
            lottoTall.Add(nextInt);
        }
    }
}

foreach(int i in Lotto())
{
    Console.WriteLine(i);
}



// Space
Console.WriteLine("\n");



// Oppgave 7
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 7");
Console.ResetColor();

string[] klasser = {
  "3STA",
  "3STB",
  "3STC",
  "3STD",
  "3STE"
};

double[] antall = { 9, 9, 1, 1, 6 };

ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Microcharts();

Tick[] kategorier = new Tick[klasser.Length];
Bar[] stolper = new Bar[klasser.Length];

for (int i = 0; i < klasser.Length; i++)
{
    stolper[i] = new() { Position = i, Value = antall[i], FillColor = myPlot.Add.Palette.GetColor(i)};
    kategorier[i] = new Tick(i, klasser[i]);
}

var stolpediagram = myPlot.Add.Bars(stolper);
myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(kategorier);

myPlot.XLabel("Klasse");
myPlot.YLabel("Antall Elever");
myPlot.Title("IT2 2024");

myPlot.SavePng("stolpediagram.png", 400, 300);
