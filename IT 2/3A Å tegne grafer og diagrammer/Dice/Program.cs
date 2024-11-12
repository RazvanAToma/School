using ScottPlot;
Random rnd = new Random();


ScottPlot.Plot myPlot = new();


int count = 100000;

double[] values = new double[count];

for (int i = 0; i < count; i += 1)
{
    values[i] = rnd.Next(1, 7);
}


var hist = ScottPlot.Statistics.Histogram.WithBinCount(6, values);
var barPlot = myPlot.Add.Bars(hist.Bins, hist.Counts);


foreach (var bar in barPlot.Bars)
{
    bar.Size = hist.FirstBinSize * .5;
}


myPlot.Axes.Margins(bottom: 0);
myPlot.YLabel("Count");
myPlot.XLabel("Values");

myPlot.SavePng("graphs/rolling.png", 800, 600);
