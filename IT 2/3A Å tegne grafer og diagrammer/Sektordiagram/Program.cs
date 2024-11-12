
using ScottPlot;

string[] partier = { "AP", "FrP", "H", "KrF", "MDG", "R", "Sp", "SV", "V", "PF" };
double[] representanter = { 48, 21, 36, 3, 3, 8, 28, 13, 8, 1 };
string[] farger = { "#f58c68", "#004281", "#3396d2", "#d2bc2a", "#25a23c", "#5d0008", "#90cc93", "#d34d2f", "#005245", "#f69465" };

ScottPlot.Plot myPlot = new();
PieSlice[] kakestykker = new PieSlice[partier.Length];

for (int i = 0; i < partier.Length; i++)
{
    kakestykker[i] = new PieSlice() { Value = representanter[i], Label = partier[i], FillColor = Color.FromHex(farger[i]), LabelFontColor = Color.FromHex(farger[i]) };
}

var sektordiagram = myPlot.Add.Pie(kakestykker);

// grid og akser er kun i veien for sektordiagrammer:
myPlot.HideGrid();
myPlot.Axes.Frameless();

myPlot.SavePng("graphs/kakediagram.png", 400, 400);




// Oppgave 4

string[] sex = { "Boys", "Girls" };
double[] count = { 1375, 7286 };
string[] colors = { "0078ff", "f800a2" };

ScottPlot.Plot division = new();
PieSlice[] slices = new PieSlice[sex.Length];

for (int i = 0; i < sex.Length; i += 1)
{
    slices[i] = new PieSlice()
    {
        Value = count[i],
        Label = sex[i],
        FillColor = Color.FromHex(colors[i]),
        LabelFontColor = Color.FromHex(colors[i]),
        LabelFontSize = 18,
        LabelBold = true,
    };
}

var pieChart = division.Add.Pie(slices);
pieChart.ExplodeFraction = 0.05;

division.HideGrid();
division.Axes.Frameless();

division.SavePng("graphs/Division Pie Chart.png", 600, 600);