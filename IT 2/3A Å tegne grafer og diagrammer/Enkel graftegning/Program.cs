using ScottPlot;

// Quickstart

List<double> testX = new List<double>();
List<double> testY = new List<double>();

int i = 0;
int boundary = 100;

while (i < boundary)
{
    testX.Add(i);
    testY.Add(Math.Pow(i, 2));
    i += 1;
}

testX.ToArray();
testY.ToArray();

ScottPlot.Plot myPlot = new();
myPlot.Add.Scatter(testX, testY);

myPlot.SavePng("graphs/kvadrattallScatterTil100.png", 800, 600);



// Tegne grafer
double f(double x)
{
    return (3 * x * x) + (2 * x) - 7;
}

ScottPlot.Plot functionPlot = new();
functionPlot.Add.Function(f);
functionPlot.Axes.SetLimits(-2, 2, -10, 10);


functionPlot.SavePng("funksjoner/3x^2+2x-7.png", 800, 600);




// Oppgave 1
double g(double x)
{
    return (4 * Math.Pow(x, 3)) - (Math.Pow(x, 5));
}

ScottPlot.Plot oppgave1 = new();

var myScatter = oppgave1.Add.Function(g);
oppgave1.Axes.SetLimits(-2, 2);
myScatter.LineWidth = 5;
myScatter.LinePattern = LinePattern.Dashed;

oppgave1.SavePng("funksjoner/4x^3-x^5.png", 800, 600);





// Oppgave 2

double[] dataX = { -2, -1, 0,   1,  2 };
double[] dataY = {  1,  0, 2, -3.7, 0 };

ScottPlot.Plot oppgave2 = new();
var oppgave2Scatter = oppgave2.Add.ScatterPoints(dataX, dataY);

oppgave2Scatter.MarkerShape = MarkerShape.FilledDiamond;
oppgave2Scatter.MarkerSize = 10;

oppgave2.SavePng("funksjoner/Oppgave2.png", 800, 600);
