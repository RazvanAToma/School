
// Redigere Lister 
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Redigere Lister");
Console.ResetColor();

// Legge til verdier
List<string> tegneseriefigurer = new List<string>();

tegneseriefigurer.Add("Donald Duck");
tegneseriefigurer.Add("Pondus");
tegneseriefigurer.Add("Obelix");


// "Inject"
tegneseriefigurer.Insert(1, "Asterix");