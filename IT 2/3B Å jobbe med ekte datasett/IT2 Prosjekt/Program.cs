using ScottPlot;
using CsvHelper;
using System.Globalization;


var reader = new StreamReader("Datasett_fodselstall_komma.csv");
var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

var statistikk = csv.GetRecords<Fodselstall>().ToList();

/*

Console.WriteLine("=======================================");
Console.WriteLine("||------|-------|---------|----------||");
Console.WriteLine("|| Year | Total | MoveIns | MoveOuts ||");
Console.WriteLine("||------|-------|---------|----------||");


foreach (Fodselstall ting in statistikk)
{
    string year = ting.Year.ToString();
    string born = ting.Born.ToString();
    string moveIns = ting.MoveIns.ToString();
    string moveOuts = ting.MoveOuts.ToString();

    if (born.Length < 5) { while (born.Length != 5) { born += " "; } }

    if (moveIns.Length < 7) { while (moveIns.Length != 7) { moveIns += " "; } }

    if (moveOuts.Length < 8) { while (moveOuts.Length != 8) { moveOuts += " "; } }

    Console.WriteLine($"|| {year} | {born} | {moveIns} | {moveOuts} ||");
    Console.WriteLine("||------|-------|---------|----------||");
}

Console.WriteLine("=======================================");

*/



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

/*
Høy vanskelighetsgrad (karakter 5-6)
	• Lag et program som lar brukeren velge hvilken graf som skal tegnes, og i hvilken periode:
		○ Brukeren skal selv kunne velge mellom fødselstall, innflytting, utflytting eller nettoinnvandring
		○ Brukeren skal selv velge hvilket år grafen skal starte og slutte
		○ Grafen brukeren ber om skal tegnes, og gis en passende tittel (for eksempel "Innflytting fra 1980 til 1990" dersom det er det brukeren har valgt.)
        ○ Programmet bør sjekke at input fra brukeren er gyldig, slik at det ikke kræsjer når det prøver å tegne grafen
*/

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
    Console.Write($"\nDu har valgt {valgtKategori} ");
    Console.WriteLine($"med intervallet {intervallStart} til {intervallSlutt}, som er {intervallSlutt - intervallStart} år.");


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
    myPlot.HideGrid();
    myPlot.Axes.Margins(bottom: 0);


    // Labels
    myPlot.XLabel("Årstall");
    myPlot.YLabel("Antall");
    myPlot.Title(plotTitle);

    myPlot.SavePng("graphs/stolpediagram.png", 1280, 720);
}

// Oppgave1();


/*
Høy vanskelighetsgrad(karakter 5-6)
	• Bruk regresjon i ScottPlot til å finne en lineær sammenheng for fødselstallene.
		○ Lag en graf som viser den lineære sammenhengen sammen med de faktiske fødselstallene
		○ Hvilke 5 år har fødselstall som skiller seg mest ut fra den lineære sammenhengen?
*/

void Oppgave2()
{

}

Oppgave2();