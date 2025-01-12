
Butikk butikk1 = new Butikk("Rema 1000", "Lierstranda", "07.00 - 23.00");
Butikk butikk2 = new Butikk("Kiwi", "Stromso", "07.00 - 23.00");

butikk1.LeggTilProdukt(new Produkt("Eple", 29.90f));
butikk1.LeggTilProdukt(new Produkt("Banan", 24.90f));
butikk1.LeggTilProdukt(new Produkt("Jordbaer", 59.90f));

butikk2.LeggTilProdukt(new Produkt("Eple", 28.90f));
butikk2.LeggTilProdukt(new Produkt("Banan", 28.90f));
butikk2.LeggTilProdukt(new Produkt("Jordbaer", 99.90f));

foreach (var item in butikk1.Produkter)
{
    Console.WriteLine($"{item.Name} - {item.Price} NOK pr. Kilo");
}

foreach (var item in butikk2.Produkter)
{
    Console.WriteLine($"{item.Name} - {item.Price} NOK pr. Kilo");
}