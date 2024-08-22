
// Utskrift med Console.Write() og Console.WriteLint()
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Utskrift med Console.Write() og Console.WriteLint()");
Console.ResetColor();


Console.WriteLine("Hei");
Console.WriteLine("Verden");

Console.Write("Hei");
Console.Write("Verden\n\n\n");



// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

Console.Write("Hello, ");
Console.Write("World!\n");

Console.WriteLine("Hello, World!\n\n");



// Oppgave 2a
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2a");
Console.ResetColor();

Console.Write("Kolonne 1    Kolonne 2\n");
Console.Write("342          6543\n\n");



// Oppgave 2b
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2b");
Console.ResetColor();

Console.WriteLine("Kolonne 1    Kolonne 2");
Console.WriteLine("342          6543\n\n");




// Variabler
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Variabler");
Console.ResetColor();

string fornavn = "Jesper";
Console.WriteLine(fornavn + "\n\n");

// Kan ogsaa gjores slik:
/*
 
 * string fornavn;
 * fornavn = "Jesper";
 * Console.WriteLine(fornavn);

 */



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

string mittNavn = "Razvan";
Console.WriteLine(mittNavn);



// Oppgave 4a
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4a");
Console.ResetColor();

Console.WriteLine("Fornavn har ingen verdi\n");



// Oppgave 4b
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4b");
Console.ResetColor();

Console.WriteLine("Fornavn variabelen finnes ikke naar brukeren prover aa gi den en verdi\n");



// Oppgave 5
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 5");
Console.ResetColor();

Console.WriteLine("Programmet har en variabel som blir satt til Jesper, som saa blir byttet til Trine\n" +
    "Det  blir saa printet Hei Trine, og saa Hvordan har du det Trine?\n" +
    "Til slutt saa blir fornavnet endret til Line\n");


Console.WriteLine("Man trenger ikke alle linjene\n");

string fornavnEksempel = "Trine";

Console.WriteLine("Hei, " + fornavnEksempel + "\n" +
    "Hvordan har du det, " + fornavnEksempel + "?");

fornavnEksempel = "Line";