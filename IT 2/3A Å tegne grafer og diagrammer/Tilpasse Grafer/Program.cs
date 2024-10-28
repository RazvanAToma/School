using ScottPlot;
using ScottPlot.Statistics;

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

ScottPlot.Plot myPlot = new();
myPlot.Add.Scatter(dataX, dataY);
myPlot.XLabel("Navn på x-aksen");
myPlot.YLabel("Navn på y-aksen");
myPlot.Title("Tittel på grafen");
myPlot.Axes.SetLimits(-1, 6, -5, 30);

myPlot.SavePng("graphs/GrafMedNavn.png", 800, 600);




// Oppgave 1

//ScottPlot.Plot oppgave1 = new();

//double f(double x)
//{
//    return 2 * x - 3;
//}

//var xLine = oppgave1.Add.HorizontalLine(0);
//var yLine = oppgave1.Add.VerticalLine(0);
//var graph = oppgave1.Add.Function(f);

//xLine.LineColor = Colors.Red;
//yLine.LineColor = Colors.Blue;
//graph.LinePattern = LinePattern.Dotted;
//graph.LineWidth = 5;
//graph.LineColor = Colors.Black;

//Image bgImage = new(@"C:\Users\razva\Documents\GitHub\School\IT 2\3A Å tegne grafer og diagrammer\Tilpasse Grafer\bin\Debug\net8.0\graphs\pepe.jpg");
//oppgave1.FigureBackground.Image = bgImage;

//oppgave1.Axes.SetLimits(-5, 5, -5, 5);

//oppgave1.SavePng("graphs/oppgave1.png", 800, 600);




// Oppgave 2

//ScottPlot.Plot oppgave2 = new();

//double f(double x) { return 2 * x + 1; }
//double g(double x) { return Math.Pow(x, 2) - 3; }
//double h(double x) { return Math.Pow(2, x); }
//double i(double x) { return x/3; }

//oppgave2.Add.Palette = new ScottPlot.Palettes.Tsitsulin();

//var fGraph = oppgave2.Add.Function(f);
//fGraph.LegendText = "2x^2 + 1";
//fGraph.LineWidth = 4;

//var gGraph = oppgave2.Add.Function(g);
//gGraph.LegendText = "x^2 - 3";
//gGraph.LineWidth = 4;

//var hGraph = oppgave2.Add.Function(h);
//hGraph.LegendText = "2^x";
//hGraph.LineWidth = 4;

//var iGraph = oppgave2.Add.Function(i);
//iGraph.LegendText = "x/3";
//iGraph.LineWidth = 4;


//// X and Y axes
//// x
//var xAxis = oppgave2.Add.VerticalLine(0);
//xAxis.LineColor = Colors.Black;
//xAxis.LinePattern = LinePattern.Dashed;

//// y
//var yAxis = oppgave2.Add.HorizontalLine(0);
//yAxis.LineColor = Colors.Black;
//yAxis.LinePattern = LinePattern.Dashed;


//// Legend
//oppgave2.ShowLegend();
//oppgave2.Legend.Alignment = ScottPlot.Alignment.UpperLeft;


//// Limits
//oppgave2.Axes.SetLimits(-10, 10, -10, 10);


//// Save
//oppgave2.SavePng("graphs/oppgave2.png", 800, 600);






// Oppgave 3

ScottPlot.Plot oppgave3 = new();

int[] year =        { 2000,    2001,   2002,     2003,    2004,    2005,    2006,    2007,    2008,    2009,    2010,    2011,    2012,    2013,    2014,    2015,    2016,    2017,    2018,    2019,    2020,    2021,    2022};
int[] population =  { 4478497, 4503436, 4524066, 4552252, 4577457, 4606363, 4640219, 4681134, 4737171, 4799252, 4858199, 4920305, 4985870, 5051275, 5109056, 5165802, 5213985, 5258317, 5295619, 5328212, 5367580, 5391369, 5425270};

DateTime[] yearPlus = year.Select(x => new DateTime(x, 1, 1)).ToArray();

var line = oppgave3.Add.ScatterLine(yearPlus, population);
line.LineColor = Colors.Black;
line.LineWidth = 3;

var points = oppgave3.Add.ScatterPoints(yearPlus, population);
points.MarkerShape = MarkerShape.Cross;
points.MarkerColor = Colors.Black;
points.MarkerSize = 7;


oppgave3.XLabel("Year");
oppgave3.YLabel("Population");
oppgave3.Title("Developement of Norways population");

oppgave3.Axes.SetLimits(2000, 2022, 4400000, 5500000);
oppgave3.Axes.DateTimeTicksBottom();

oppgave3.SavePng("graphs/oppgave3.png", 800, 600);