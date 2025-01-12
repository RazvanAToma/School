using System;

public class Produkt
{
    public string Name { get; set; }
    public float Price { get; set; }

    public Produkt(string name, float price)
    {
        Name = name;
        Price = price;
    }
}
