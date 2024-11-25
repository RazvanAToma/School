
Ansatt ingvild = new Ansatt("Ingvild", "Lundanes", 37, 37.5, "Lektor");
Ansatt kjeld = new Ansatt("Kjeld", "Massali", 41, 37.5, "Lektor");

List<Ansatt> ansattListe = new List<Ansatt> { ingvild, kjeld };

foreach (Ansatt ansatt in ansattListe)
{
    Console.WriteLine(ansatt.Fornavn);
    Console.WriteLine(ansatt.Etternavn);
    Console.WriteLine("\n");
}