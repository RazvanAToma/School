
// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

string[] tall = File.ReadAllLines("files/tall.txt");

foreach (string str in tall)
{
    double sum = 0;
    double avg = 0;

    string[] rad = str.Split("-");

    Console.Write("Tall:");

    foreach (string num in rad)
    {
        Console.Write($" {num}");

        sum += double.Parse(num);
    }

    Console.WriteLine("");

    avg = sum / rad.Length;

    Console.WriteLine($"Sum: {sum}, Gjennomsnitt: {avg} \n");
}