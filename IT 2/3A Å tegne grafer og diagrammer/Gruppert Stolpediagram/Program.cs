using ScottPlot;

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

double[] antallGutter = { 3459, 3900, 1375, 1029, 775, 4650, 70, 75, 1109, 1166 };
double[] antallJenter = { 352, 268, 7286, 1028, 709, 851, 243, 826, 200, 895 };

ScottPlot.Plot myPlot = new();
Tick[] kategorier = new Tick[utdanningsprogram.Length];
Bar[] stolper = new Bar[utdanningsprogram.Length * 2]; // dobbelt så mange søyler som utdanningsprogrammer

int posisjon = 0;
for (int i = 0; i < utdanningsprogram.Length; i++) // løkka lager en gruppe for hvert utdanningsprogram
{

    stolper[2 * i] = new() { Position = posisjon, Value = antallGutter[i], FillColor = Colors.Blue };
    stolper[2 * i + 1] = new Bar { Position = posisjon + 1, Value = antallJenter[i], FillColor = Colors.DeepPink };
    kategorier[i] = new Tick(3 * i + 0.5, utdanningsprogram[i]);
    posisjon += 3; // sørger for én ledig plass mellom hver gruppe
}
// Manuelt oppsett av legend:
myPlot.Legend.IsVisible = true;
myPlot.Legend.Alignment = Alignment.UpperRight;
myPlot.Legend.ManualItems.Add(new() { LabelText = "Gutter", FillColor = Colors.Blue });
myPlot.Legend.ManualItems.Add(new() { LabelText = "Jenter", FillColor = Colors.DeepPink });

var stolpediagram = myPlot.Add.Bars(stolper);
stolpediagram.Horizontal = true;
myPlot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericManual(kategorier);
myPlot.HideGrid();
myPlot.Axes.Margins(left: 0);

myPlot.SavePng("graphs/stolpediagram_grupper.png", 800, 400);
