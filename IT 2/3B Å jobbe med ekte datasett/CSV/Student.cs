using CsvHelper.Configuration.Attributes;

public class Studentstatistikk
{
    [Name("År")]
    public int Year { get; set; }

    [Name("Menn")]
    [Default(0)]
    public int Men { get; set; }

    [Name("Kvinner")]
    [Default(0)]
    public int Women { get; set; }
}
