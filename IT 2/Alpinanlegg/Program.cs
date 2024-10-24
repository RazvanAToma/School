
// Applikasjon som beregner prisen paa et heiskort for inntil en uke, basert paa alder og antall dager

/*
 * Krav:
 * Standardpris:
 *  200 NOK for Voksne per dag
 *  100 NOK for Barn (0 - 12) per dag
 * Beregnet pris for voksne > 1000 NOK ---> 1000 NOK
 * Beregnet pris for barn > 500 NOK ---> 500 NOK
 * 
 * Tilbakemelding paa hvor stort avslaget er
 * Ikke mulig for lengre enn en uke
*/


int voksne;
int barn;
int folk;

const int voksenPris = 200;
const int barnPris = 100;
int dager;


int getDays()
{
    while (true)
    {
        dager = 0;

        Console.Write("Hvor lenge vil dere være her: ");
        try
        {
            dager = int.Parse(Console.ReadLine());

            if (dager > 7 || dager < 0)
            {
                Console.WriteLine("Kan ikke være mindre enn 0, eller større enn 7");
            }
            else
            {
                return dager;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Skriv inn et tall, skal ikke være mer enn sju dager");
        }
    }
}

void getPeople()
{
    Console.Write("Hvor mange folk: ");
    folk = int.Parse(Console.ReadLine());

    int counter = 0;

    while (folk != counter)
    {
        counter += 1;
        Console.WriteLine("Person {counter}");
        Console.Write("Hvor gammel er du:");
        
    }
}