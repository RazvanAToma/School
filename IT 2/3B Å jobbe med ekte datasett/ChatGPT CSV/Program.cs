using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

var reader = new StreamReader("salgsdata.csv");
var config = new CsvConfiguration(CultureInfo.InvariantCulture) { MissingFieldFound = null };
var csv = new CsvReader(reader, config);

var statistikkListe = csv.GetRecords<Salgsdatastatistikk>().ToList();


double totalOmsetningHodetelefoner = 0;
double totalOmsetningLaptop = 0;
double totalOmsetningMobiltelefon = 0;
double totalOmsetningNettbrett = 0;
double totalOmsetningSmartklokke = 0;

foreach (Salgsdatastatistikk data in statistikkListe)
{
    if (data.Category == "Hodetelefoner")
    {
        totalOmsetningHodetelefoner += data.TotalPrice;
    }
    else if (data.Category == "Laptop")
    {
        totalOmsetningLaptop += data.TotalPrice;
    }
    else if (data.Category == "Mobiltelefon")
    {
        totalOmsetningMobiltelefon += data.TotalPrice;
    }
    else if (data.Category == "Nettbrett")
    {
        totalOmsetningNettbrett += data.TotalPrice;
    }
    else if (data.Category == "Smartklokke")
    {
        totalOmsetningSmartklokke += data.TotalPrice;
    }
}


Console.WriteLine($"{totalOmsetningHodetelefoner}\n{totalOmsetningLaptop}\n{totalOmsetningMobiltelefon}\n{totalOmsetningNettbrett}\n{totalOmsetningSmartklokke}");