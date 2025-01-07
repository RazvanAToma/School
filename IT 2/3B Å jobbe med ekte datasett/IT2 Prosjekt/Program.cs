using ScottPlot;
using CsvHelper;
using System.Globalization;
using System.Diagnostics.Metrics;


var reader = new StreamReader("Datasett_fodselstall_komma.csv");
var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

var statistikk = csv.GetRecords<Fodselstall>().ToList();


// Dictionaries for årstall og respektive verdier
Dictionary<int, int> yearAndBorn = new Dictionary<int, int>();
Dictionary<int, int> yearAndMoveIns = new Dictionary<int, int>();
Dictionary<int, int> yearAndMoveOuts = new Dictionary<int, int>();

foreach (Fodselstall info in statistikk)
{
    yearAndBorn.Add(info.Year, info.Born);
    yearAndMoveIns.Add(info.Year, info.MoveIns);
    yearAndMoveOuts.Add(info.Year, info.MoveOuts);
}

void Oppgave1()
{
    // Velge Kategori
    string[] muligeKategorier = { "fodselstall", "innflytting", "utflytting", "nettoinnvandring" };
    string valgtKategori = "";

    while (true)
    {
        Console.WriteLine("Du kan velge mellom disse kategoriene:");

        foreach (string kategori in muligeKategorier)
        {
            Console.WriteLine($"- {kategori}");
        }

        Console.WriteLine(""); // mellomrom for øya

        Console.Write("Velg en kategori for grafen: ");
        valgtKategori = Console.ReadLine().ToLower();

        // Sjekke gyldighet
        if (muligeKategorier.Contains(valgtKategori))
        {
            break;
        }
        else
        {
            Console.WriteLine("\nKjenner ikke igjen kategorien, prøv på nytt.");

            Console.WriteLine("\n---\n");
        }
    }


    // Intervall
    int intervallStart;
    int intervallSlutt;

    while (true)
    {
        Console.WriteLine("Du kan velge to årstall mellom 1945 og 2024");

        Console.Write("Fra: ");
        string intervallStartStr = Console.ReadLine();

        Console.Write("Til: ");
        string intervallSluttStr = Console.ReadLine();

        // Sjekke gyldighet
        try
        {
            intervallStart = int.Parse(intervallStartStr);
            intervallSlutt = int.Parse(intervallSluttStr);

            // Grov if setning
            if ((intervallStart >= 1945 && intervallStart <= 2024) && ((intervallSlutt >= intervallStart) && (intervallSlutt >= 1945 && intervallSlutt <= 2024)))
            {
                break;
            }
            else
            {
                Console.WriteLine("\nUgyldig intervall... Prøv på nytt.");
                Console.WriteLine("\n---\n");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("\nUgyldig intervall... Prøv på nytt.");
            Console.WriteLine("\n---\n");
        }
    }

    // Oppsummering
    Console.WriteLine($"\nDu har valgt {valgtKategori} med intervallet {intervallStart} til {intervallSlutt}, som er {intervallSlutt - intervallStart} år.");

    // Prep for graftegning
    List<string> aarstall = new List<string>();
    List<double> antall = new List<double>();

    string plotTitle = "";

    int counter = intervallStart;
    while (aarstall.Count() < (intervallSlutt - intervallStart) + 1)
    {
        aarstall.Add(counter.ToString());

        switch (valgtKategori)
        {
            case "fodselstall":
                antall.Add(yearAndBorn[counter]);
                plotTitle = $"Fødselstall fra {intervallStart} til {intervallSlutt}";
                break;

            case "innflytting":
                antall.Add(yearAndMoveIns[counter]);
                plotTitle = $"Innflyttinger fra {intervallStart} til {intervallSlutt}";
                break;

            case "utflytting":
                antall.Add(yearAndMoveOuts[counter]);
                plotTitle = $"Utflyttinger fra {intervallStart} til {intervallSlutt}";
                break;

            case "nettoinnvandring":
                antall.Add(yearAndMoveIns[counter] - yearAndMoveOuts[counter]);
                plotTitle = $"Nettoinnvandring fra {intervallStart} til {intervallSlutt}";
                break;
        }
        counter += 1;
    }

    // Graftegning
    ScottPlot.Plot myPlot = new();
    myPlot.Add.Palette = new ScottPlot.Palettes.Category20();
    Tick[] kategorier = new Tick[aarstall.Count];
    Bar[] stolper = new Bar[aarstall.Count];

    for (int i = 0; i < aarstall.Count; i++)
    {
        stolper[i] = new() { Position = i, Value = antall[i], FillColor = myPlot.Add.Palette.GetColor(i) };
        kategorier[i] = new Tick(i, aarstall[i]);
    }

    var stolpediagram = myPlot.Add.Bars(stolper);
    myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(kategorier);
    myPlot.Axes.Bottom.TickLabelStyle.Rotation = -45;
    myPlot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;
    myPlot.Axes.Margins(left: 0.01, right: 0.01, bottom: 0.01);

    // Labels
    myPlot.XLabel("Årstall");
    myPlot.YLabel("Antall");
    myPlot.Title(plotTitle);

    // Lagre
    myPlot.SavePng("graphs/stolpediagram.png", 1280, 720);
}

Oppgave1();


void Oppgave2()
{
    ScottPlot.Plot myPlot2 = new();

    List<double> aar = new List<double>();
    List<double> fodsler = new List<double>();

    foreach (KeyValuePair<int, int> pair in yearAndBorn)
    {
        aar.Add(pair.Key);
        fodsler.Add(pair.Value);
    }

    // Punkter
    var sp = myPlot2.Add.Scatter(aar, fodsler);
    sp.LineWidth = 0;
    sp.MarkerSize = 10;

    // Regresjon
    ScottPlot.Statistics.LinearRegression reg = new(aar.ToArray(), fodsler.ToArray());

    Coordinates pt1 = new(aar.First(), reg.GetValue(aar.First()));
    Coordinates pt2 = new(aar.Last(), reg.GetValue(aar.Last()));
    var line = myPlot2.Add.Line(pt1, pt2);
    line.MarkerSize = 0;
    line.LineWidth = 2;
    line.LinePattern = LinePattern.Dashed;

    // Ticks
    Tick[] ticks = new Tick[aar.Count];
    for (int i = 0; i < aar.Count; i++)
    {
        ticks[i] = new Tick(aar[i], aar[i].ToString());
    }

    // Axes
    myPlot2.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
    myPlot2.Axes.Bottom.TickLabelStyle.Rotation = -45;
    myPlot2.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;
    myPlot2.Axes.Margins(left: 0.01, right: 0.01, bottom: 0.01);
    myPlot2.Axes.SetLimits(top: 75000, bottom: 45000);

    // Legend
    myPlot2.Legend.IsVisible = true;
    myPlot2.Legend.Alignment = Alignment.UpperRight;
    myPlot2.Legend.ManualItems.Add(new() { LabelText = "Fødselstall", FillColor = Colors.Blue });
    myPlot2.Legend.ManualItems.Add(new() { LabelText = "Lineær regresjon", FillColor = Colors.Orange });

    // Labels and Title
    myPlot2.XLabel("Årstall");
    myPlot2.YLabel("Antall fødsler");
    myPlot2.Title("Regresjonsanalyse av fødselstall mellom 1945 og 2024");

    // Lagre
    myPlot2.SavePng("graphs/regresjon.png", 1280, 720);
}

Oppgave2();


void Oppgave3()
{
    List<string> tiAar = new List<string>();
    List<double> fodsler = new List<double>();
    List<double> nettoInnvandring = new List<double>();

    foreach (KeyValuePair<int, int> par in yearAndBorn)
    {
       if (par.Key % 10 == 0)
       {
            tiAar.Add(par.Key.ToString());
            fodsler.Add(par.Value);
            nettoInnvandring.Add((yearAndMoveIns[par.Key] - yearAndMoveOuts[par.Key]));
       }
    }

    ScottPlot.Plot myPlot3 = new();
    Tick[] aarstall = new Tick[tiAar.Count];
    Bar[] stolper = new Bar[tiAar.Count * 2]; // dobbelt så mange søyler som utdanningsprogrammer


    int posisjon = 0;
    for (int i = 0; i < tiAar.Count; i++) // løkka lager en gruppe for hvert utdanningsprogram
    {

        stolper[2 * i] = new() { Position = posisjon, Value = fodsler[i], FillColor = Colors.Teal };
        stolper[2 * i + 1] = new Bar { Position = posisjon + 1, Value = nettoInnvandring[i], FillColor = Colors.Orange };
        aarstall[i] = new Tick(3 * i + 0.5, tiAar[i]);
        posisjon += 3; // sørger for én ledig plass mellom hver gruppe
    }

    // Manuelt oppsett av legend:
    myPlot3.Legend.IsVisible = true;
    myPlot3.Legend.Alignment = Alignment.UpperRight;
    myPlot3.Legend.ManualItems.Add(new() { LabelText = "Fødselstall", FillColor = Colors.Teal });
    myPlot3.Legend.ManualItems.Add(new() { LabelText = "Nettoinnvandring", FillColor = Colors.Orange });

    var stolpediagram = myPlot3.Add.Bars(stolper);
    myPlot3.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(aarstall);
    myPlot3.Axes.Margins(left: 0.01, right: 0.01, bottom: 0.01);

    myPlot3.XLabel("Årstall");
    myPlot3.YLabel("Antall");
    myPlot3.Title("Fødselstall og Nettoinnvandring hvert tiår");

    myPlot3.SavePng("graphs/gruppert.png", 1280, 720);
}

Oppgave3();