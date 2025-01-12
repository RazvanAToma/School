using System;

public class Butikk
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string OpeningHours { get; set; }
    public List<Produkt> Produkter { get; set; }

    public Butikk(string name, string address, string openingHours)
    {
        Name = name;
        Address = address;
        OpeningHours = openingHours;
        Produkter = new List<Produkt>();
    }

    public void LeggTilProdukt(Produkt produkt)
    {
        Produkter.Add(produkt);
    }
}
