
// Oppgave 3

List<int> ints = new List<int>();

while (ints.Sum(i => i) < 50)
{
    Console.Write("Skriv inn ett tall: ");
    int num = int.Parse(Console.ReadLine());

    ints.Add(num);
    Console.WriteLine($"Summen er nå {ints.Sum(i => i)}");
}


