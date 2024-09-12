
DateTime start = DateTime.Now;

int antall = 1000;

Random rnd = new Random();
void colorPicker()
{
    int number = rnd.Next(13);

    switch (number)
    {
        case 0:
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case 4:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            break;
        case 5:
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            break;
        case 6:
            Console.ForegroundColor = ConsoleColor.Cyan;
            break;
        case 7:
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            break;
        case 8:
            Console.ForegroundColor = ConsoleColor.DarkRed;
            break;
        case 9:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            break;
        case 10:
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
        case 11:
            Console.ForegroundColor = ConsoleColor.Magenta;
            break;
        case 12:
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            break;
    }
}

for (int i = 0; i < antall; i += 1)
{
    for (int j = 0; j < antall; j += 1)
    {
        colorPicker();
        Console.Write("-");
    }
}

DateTime stop = DateTime.Now;


TimeSpan elapsedTime = stop - start;
Console.WriteLine(elapsedTime);