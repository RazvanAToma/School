
using CsvHelper;
using System.Globalization;

var reader = new StreamReader("Datasett_fodselstall_komma.csv");
var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

var statistikk = csv.GetRecords<Fodselstall>().ToList();

foreach(Fodselstall ting in statistikk)
{
    Console.WriteLine($"{ting.Year}");
}