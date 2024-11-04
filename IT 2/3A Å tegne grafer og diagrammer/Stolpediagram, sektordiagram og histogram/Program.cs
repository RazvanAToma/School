using ScottPlot;


// Verdier:
string[] utdanningsprogram = {
  "Bygg- og anleggsteknikk",
  "Elektro og datateknologi",
  "Helse- og oppvekstfag",
  "Naturbruk",
  "Restaurant- og matfag",
  "Teknologi- og industrifag",
  "Håndverk, design og produktutvikling",
  "Frisør, blomster, interiør og eksponeringsdesign",
  "Informasjonsteknologi og medieproduksjon",
  "Salg, service og reiseliv"
};

double[] antall = { 3811, 4168, 8661, 2057, 1484, 5501, 313, 901, 1309, 2061 };

ScottPlot.Plot myPlot = new();
myPlot.Add.Palette = new ScottPlot.Palettes.Microcharts();

Tick[] kategorier = new Tick[utdanningsprogram.Length];
Bar[] stolper = new Bar[utdanningsprogram.Length];

for (int i = 0; i < utdanningsprogram.Length; i++)
{
    stolper[i] = new() { Position = i, Value = antall[i], FillColor = myPlot.Add.Palette.GetColor(i) };
    kategorier[i] = new Tick(i, utdanningsprogram[i]);
}

var stolpediagram = myPlot.Add.Bars(stolper);
stolpediagram.Horizontal = true;
myPlot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericManual(kategorier);
myPlot.HideGrid();
myPlot.Axes.Margins(left: 0);

myPlot.SavePng("graphs/stolpediagram.png", 800, 300);




// Oppgave 1

string[] countries =
{
    "China",
    "Japan",
    "Germany",
    "USA",
    "South Korea",
    "India",
    "Spain",
    "Mexico",
    "Brazil",
    "UK"
};

double[] cars =
{
    24420744,
    7873886,
    5746808,
    3934357,
    3859991,
    3677605,
    2354117,
    1993168,
    1778464,
    1722698
};

ScottPlot.Plot carGraph = new();
carGraph.Add.Palette = new ScottPlot.Palettes.Microcharts();

Bar[] bars = new Bar[countries.Length];
Tick[] ticks = new Tick[countries.Length];

for (int i = 0; i < countries.Length; i += 1)
{
    bars[i] = new() { Position = i, Value = cars[i], FillColor = carGraph.Add.Palette.GetColor(i) };
    ticks[i] = new Tick(i, countries[i]);
}

// Bars
var barGraph = carGraph.Add.Bars(bars);

// Ticks
carGraph.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
carGraph.Axes.Bottom.TickLabelStyle.Rotation = -45;
carGraph.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;

// Margins
carGraph.Axes.Margins(bottom: 0.01);

// Padding
PixelPadding padding = new(left: 80, right: 10, bottom: 60, top: 10);
carGraph.Layout.Fixed(padding);

carGraph.SavePng("graphs/carGraph.png", 500, 400);





// Oppgave 2

string[] fremkomstmidler =
{
    "Går",
    "Sykler",
    "Moped",
    "Kjører bil",
    "Sitter på i bil",
    "Buss"
};

double[] verdier =
{
    4,
    5,
    0,
    6,
    2,
    4
};

ScottPlot.Plot fremkomster = new();
fremkomster.Add.Palette = new ScottPlot.Palettes.ColorblindFriendly();

Bar[] stolps = new Bar[fremkomstmidler.Length];
Tick[] ticker = new Tick[fremkomstmidler.Length];

for (int i = 0; i < fremkomstmidler.Length; i += 1)
{
    stolps[i] = new Bar { Position = i, Value = verdier[i], FillColor = fremkomster.Add.Palette.GetColor(i) };
    ticker[i] = new Tick(i, fremkomstmidler[i]);
}

var firkanter = fremkomster.Add.Bars(stolps);

fremkomster.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticker);

fremkomster.SavePng("graphs/fremkomster.png", 800, 600);