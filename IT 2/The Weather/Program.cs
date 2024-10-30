using ScottPlot;
using ScottPlot.Plottables;

Dictionary<double, double> readings = new Dictionary<double, double>();

Random rnd = new Random();

int min = 0;
int max = 10;

// Generate data for 31 days
for (int i = 0; i < 31; i += 1)
{
    readings[i] = rnd.NextDouble() * max; // Use NextDouble and scale by max

    if (i % 5 == 0)
    {
        max -= 1; // Decrease max every 5 days
    }
}

// Separate keys and values into arrays for plotting
double[] days = readings.Keys.ToArray();
double[] values = readings.Values.ToArray();

// Create the plot
ScottPlot.Plot weatherReport = new();

// Plot the scatter line and points
var scatterLine = weatherReport.Add.ScatterLine(days, values);
var scatterPoints = weatherReport.Add.ScatterPoints(days, values);

// Configure line appearance
scatterLine.LineColor = Colors.Black;
scatterLine.LineWidth = 3;

// Configure points appearance
scatterPoints.MarkerShape = MarkerShape.Cross;
scatterPoints.MarkerColor = Colors.Black;
scatterPoints.MarkerSize = 5;

// Calculate and plot the regression line
ScottPlot.Statistics.LinearRegression reg = new(days, values);

// Define two points for the regression line
Coordinates pt1 = new(days.First(), reg.GetValue(days.First()));
Coordinates pt2 = new(days.Last(), reg.GetValue(days.Last()));
var line = weatherReport.Add.Line(pt1, pt2);
line.MarkerSize = 0;
line.LineWidth = 2;
line.LinePattern = LinePattern.Dashed;

// Save the plot to a PNG file
weatherReport.SavePng("graphs/weatherReport.png", 800, 600);
