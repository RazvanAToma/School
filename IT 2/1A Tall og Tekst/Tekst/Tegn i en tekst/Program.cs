
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