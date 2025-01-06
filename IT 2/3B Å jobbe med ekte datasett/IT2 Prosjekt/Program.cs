
using CsvHelper;
using System.Globalization;
using System.Net.NetworkInformation;

var reader = new StreamReader("Datasett_fodselstall_komma.csv");
var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

var statistikk = csv.GetRecords<Fodselstall>().ToList();

Console.WriteLine("=======================================");
Console.WriteLine("||------|-------|---------|----------||");
Console.WriteLine("|| Year | Total | MoveIns | MoveOuts ||");
Console.WriteLine("||------|-------|---------|----------||");


foreach (Fodselstall ting in statistikk)
{
    string year = ting.Year.ToString();
    string born = ting.Born.ToString();
    string moveIns = ting.MoveIns.ToString();
    string moveOuts = ting.MoveOuts.ToString();

    if (born.Length < 5) { while (born.Length != 5) { born += " "; } }

    if (moveIns.Length < 7) { while (moveIns.Length != 7) { moveIns += " "; } }

    if (moveOuts.Length < 8) { while (moveOuts.Length != 8) { moveOuts += " "; } }

    Console.WriteLine($"|| {year} | {born} | {moveIns} | {moveOuts} ||");
    Console.WriteLine("||------|-------|---------|----------||");
}

Console.WriteLine("=======================================");