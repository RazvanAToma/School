using CsvHelper.Configuration.Attributes;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class GooglePlaystoreApp
{
    [Name("App")]
    public string App { get; set; }

    [Name("Category")]
    public string Category { get; set; }

    [Name("Rating")]
    public float Rating { get; set; }

    [Name("Reviews")]
    public string Reviews { get; set; }

    [Name("Size")]
    public string Size { get; set; }

    [Name("Installs")]
    public string Installs { get; set; }

    [Name("Type")]
    public string Type { get; set; }

    [Name("Price")]
    public string Price { get; set; }

    [Name("Genres")]
    public string Genres { get; set; }

    [Name("Content Rating")]
    public string ContentRating { get; set; }

    [Name("Last Updated")]
    public Date LastUpdated { get; set; }

    [Name("Current Ver")]
    public string CurrentVer { get; set; }

    [Name("Android Ver")]
    public string AndroidVer { get; set; }
}
