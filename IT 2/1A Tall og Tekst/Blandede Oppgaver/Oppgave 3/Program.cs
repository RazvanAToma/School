
string maaneder = "JanFebMarAprMaiJunJulAugSepOktNovDes";

Console.Write("Skriv et maanedsnummer: ");
int maanedsNummer = int.Parse(Console.ReadLine());

int wordLength = 3;

switch (maanedsNummer)
{
    case 1:  Console.WriteLine(maaneder.Substring(0,  wordLength)); break;
    case 2:  Console.WriteLine(maaneder.Substring(3,  wordLength)); break;
    case 3:  Console.WriteLine(maaneder.Substring(6,  wordLength)); break;
    case 4:  Console.WriteLine(maaneder.Substring(9,  wordLength)); break;
    case 5:  Console.WriteLine(maaneder.Substring(12, wordLength)); break;
    case 6:  Console.WriteLine(maaneder.Substring(15, wordLength)); break;
    case 7:  Console.WriteLine(maaneder.Substring(18, wordLength)); break;
    case 8:  Console.WriteLine(maaneder.Substring(21, wordLength)); break;
    case 9:  Console.WriteLine(maaneder.Substring(24, wordLength)); break;
    case 10: Console.WriteLine(maaneder.Substring(27, wordLength)); break;
    case 11: Console.WriteLine(maaneder.Substring(30, wordLength)); break;
    case 12: Console.WriteLine(maaneder.Substring(33, wordLength)); break;
}