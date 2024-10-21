
// Oppgave 2

Console.Write("Skriv inn et tall: ");
int num = int.Parse(Console.ReadLine());

List<int> delelige = new List<int>();

for (int i = 2; i < num; i += 1)
{
    if (num % i == 0)
    {
        delelige.Add(i);
    }
}

foreach(int i in delelige)
{
    Console.WriteLine($"{num} er delelig på {i}");
}