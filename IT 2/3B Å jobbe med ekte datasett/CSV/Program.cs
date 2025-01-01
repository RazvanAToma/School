
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

var reader = new StreamReader("studenter.csv");
var config = new CsvConfiguration(CultureInfo.InvariantCulture) { MissingFieldFound = null };
var csv = new CsvReader(reader, config);

var statistikkListe = csv.GetRecords<Studentstatistikk>().ToList();


Console.WriteLine($"| Year\t| Men\t| Women\t|");

foreach (Studentstatistikk student in statistikkListe)
{
    Console.WriteLine($"-------------------------");
    Console.WriteLine($"| {student.Year}\t| {student.Men}\t| {student.Women}\t|");
}


