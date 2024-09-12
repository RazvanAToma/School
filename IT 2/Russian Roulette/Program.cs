
Random rnd = new Random();

int loadedBullets;
while (true)
{
    try
    {
        Console.Write("How many bullets? ");
        loadedBullets = int.Parse(Console.ReadLine());
        break;
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.ToString().Substring(0, ex.ToString().IndexOf("at System")));
    }
}



while (loadedBullets > 0)
{
    if (rnd.Next(7) == rnd.Next(7))
    {
        Console.WriteLine("You died");
    }
    else
    {
        Console.WriteLine("You live");
    }

    loadedBullets -= 1;
}

