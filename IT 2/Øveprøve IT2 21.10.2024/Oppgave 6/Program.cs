
// Oppgave 6

Dictionary<string, int> navnForekomster = new Dictionary<string, int>();

List<string> navneListe = new List<string> { "Petter", "Kjeld", "Ingvild", "John", "Kjeld", "Petter", "Petter" };

void checkNames(List<string> names)
{
    foreach (string navn in names)
    {
        if (navnForekomster.ContainsKey(navn))
        {
            navnForekomster[navn] += 1;
        }
        else
        {
            navnForekomster[navn] = 1;
        }
    }
}

checkNames(navneListe);

foreach(KeyValuePair<string, int> pair in navnForekomster)
{
    Console.WriteLine($"{pair.Key} - {pair.Value}");
}
