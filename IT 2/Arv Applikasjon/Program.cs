
using Arv_Applikasjon;

while (true)
{
    Console.WriteLine("Meny:");
    Console.WriteLine("1. Legg til ansatt");
    Console.WriteLine("2. Vis alle ansatte");
    Console.WriteLine("3. Avslutt");
    Console.Write("Velg et alternativ: ");
    string valg = Console.ReadLine();

    if (valg == "1")
    {
        LeggTilAnsatt();
    }
    else if (valg == "2")
    {
        foreach (Ansatt ansatt in Ansatt.AlleAnsatte)
        {
            if (ansatt is SoftwareUtvikler)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Software Utvikler:");
                Console.ResetColor();
            }
            else if (ansatt is Tester)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tester:");
                Console.ResetColor();
            }

            Console.WriteLine(ansatt.ToString());
        }
    }
    else if (valg == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ugyldig valg. Prøv igjen.\n");
    }
}

void LeggTilAnsatt()
{
    Console.WriteLine("Velg rolle: (1) SoftwareUtvikler, (2) Tester");
    string rolleValg = Console.ReadLine();

    Console.Write("Navn: ");
    string navn = Console.ReadLine();

    Console.Write("Alder: ");
    int alder = int.Parse(Console.ReadLine());

    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Tittel: ");
    string tittel = Console.ReadLine();



    if (rolleValg == "1")
    {
        Console.Write("Antall prosjekter: ");
        int prosjekter = int.Parse(Console.ReadLine());

        new SoftwareUtvikler(navn, alder, id, tittel, prosjekter);

        Console.WriteLine("Ansatt lagt til!\n");
    }
    else if (rolleValg == "2")
    {
        Console.Write("Antall programmer testet: ");
        int programmer = int.Parse(Console.ReadLine());

        new Tester(navn, alder, id, tittel, programmer);

        Console.WriteLine("Ansatt lagt til!\n");
    }
    else
    {
        Console.WriteLine("Noe gikk galt, prøv igjen senere.");
    }
}
