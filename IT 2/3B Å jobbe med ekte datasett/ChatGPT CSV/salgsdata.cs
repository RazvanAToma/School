using CsvHelper.Configuration.Attributes;

public class Salgsdatastatistikk
{
    [Name("Dato")]
    public DateOnly Date { get; set; }

    [Name("KundeID")]
    [Default("")]
    public string CustomerID { get; set; }

    [Name("Produkt")]
    [Default("")]
    public string Product { get; set; }

    [Name("Kategori")]
    [Default("")]
    public string Category { get; set; }

    [Name("Antall")]
    [Default(0)]
    public int Amount { get; set; }

    [Name("PrisPerEnhet")]
    [Default(0)]
    public double PricePerUnit { get; set; }

    [Name("TotalPris")]
    [Default(0)]
    public double TotalPrice { get; set; }

    [Name("Betalingsmetode")]
    [Default("")]
    public string PaymentMethod { get; set; }
}
