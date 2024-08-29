
// Tegn i en tekst

string sitat = "Datamaskiner er ubrukelige. De kan bare gi oss svar";
int antallTegn = sitat.Length;

Console.WriteLine(antallTegn + "\n\n");


// String Metoder
string tekst;

// To Lower
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("To Lower");
Console.ResetColor();

tekst = "Hei pÅ DEG\n";
Console.WriteLine(tekst.ToLower());



// To Upper
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("To Upper");
Console.ResetColor();

tekst = "Hei pÅ DEG\n";
Console.WriteLine(tekst.ToUpper());



// Substring
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Substring");
Console.ResetColor();

tekst = "hei på deg\n";
Console.WriteLine(tekst.Substring(4, 2));



// Replace
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Replace");
Console.ResetColor();

tekst = "hei paa deg\n";
Console.WriteLine(tekst.Replace("aa", "å"));



// Remove
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Remove");
Console.ResetColor();

tekst = "hei på deg\n";
Console.WriteLine(tekst.Remove(4, 2));



// IndexOf
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("IndexOf");
Console.ResetColor();

tekst = "hei på deg\n";
Console.WriteLine(tekst.IndexOf("e"));



// Space
Console.WriteLine("\n");



// Oppgave 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 1");
Console.ResetColor();

string oppgaveTekst = "Hallo!";

Console.WriteLine(oppgaveTekst.Length);
Console.WriteLine(oppgaveTekst[oppgaveTekst.Length - 1]);



// Space
Console.WriteLine("\n");



// Oppgave 2
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 2");
Console.ResetColor();

oppgaveTekst = "hallo!";

Console.WriteLine(oppgaveTekst.ToUpper());



// Space
Console.WriteLine("\n");



// Oppgave 3
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 3");
Console.ResetColor();

oppgaveTekst = "Datamaskiner er ubrukelige. De kan bare gi oss svar.";

oppgaveTekst = oppgaveTekst.Remove(34, 5);
oppgaveTekst = oppgaveTekst.Remove(12, 18);

Console.WriteLine(oppgaveTekst);



// Space
Console.WriteLine("\n");



// Oppgave 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Oppgave 4");
Console.ResetColor();

string fornavn = "Razvan";
string etternavn = "Toma";
int telefonNummer = 41234567;

Console.WriteLine($"{fornavn} {etternavn} har telefonnummer {telefonNummer}");