
using ScottPlot;

ScottPlot.Plot myPlot = new();

double[] heights = SampleData.MaleHeights();

var hist = ScottPlot.Statistics.Histogram.WithBinCount(100 /* Amount */, heights);
var barPlot = myPlot.Add.Bars(hist.Bins, hist.GetProbability());

foreach (var bar in barPlot.Bars)
{
    bar.Size = hist.FirstBinSize;
    bar.LineWidth = 0;
    bar.FillStyle.AntiAlias = false;
    bar.FillColor = Colors.C0.Lighten(.3);
}

// ?
ScottPlot.Statistics.ProbabilityDensity pd = new(heights);
double[] xs = Generate.Range(heights.Min(), heights.Max(), 1);
double sumBins = hist.Bins.Select(x => pd.GetY(x)).Sum();
double[] ys = pd.GetYs(xs, 1.0 / sumBins);

// Average curve
var curve = myPlot.Add.ScatterLine(xs, ys);
curve.LineWidth = 2;
curve.LineColor = Colors.Black;
curve.LinePattern = LinePattern.DenselyDashed;

myPlot.Axes.Margins(bottom: 0);
myPlot.YLabel("Probability (%)");
myPlot.XLabel("Height (cm)");

myPlot.SavePng("graphs/histogram.png", 600, 400);
