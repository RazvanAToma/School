using CsvHelper.Configuration.Attributes;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Fodselstall
{
    [Name("År")]
    [Default(0)]
    public int Year { get; set; }

    [Name("Levendefødte i alt")]
    [Default(0)]
    public int Born { get; set; }

    [Name("Innflyttinger")]
    [Default(0)]
    public int MoveIns { get; set; }

    [Name("Utflyttinger")]
    [Default(0)]
    public int MoveOuts { get; set; }
}
