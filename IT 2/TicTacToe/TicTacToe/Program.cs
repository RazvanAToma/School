
// TIC-TAC-TOE

// 2D-Array
char[,] values = { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

// Output game
void ShowGame()
{
    Console.WriteLine("\tKol 0\t Kol 1\t Kol 2");
    Console.WriteLine($"Rad 0\t{values[0, 0]}\t {values[0, 1]}\t {values[0, 2]}");
    Console.WriteLine($"Rad 1\t{values[1, 0]}\t {values[1, 1]}\t {values[1, 2]}");
    Console.WriteLine($"Rad 2\t{values[2, 0]}\t {values[2, 1]}\t {values[2, 2]}");
}

ShowGame();

// Check out of moves
bool checkOutOfMoves()
{
    int x_counter = 0;
    int o_counter = 0;

    foreach(char value in values)
    {
        if (value == 'x')
        {
            x_counter += 1;
        }
        else if (value == 'o')
        {
            o_counter += 1;
        }
    }

    if (o_counter == 3 && x_counter == 3)
    {   
        return true;
    }
    else
    {
        return false;
    }
}


// Place x or o
void Place(int row, int col, char player)
{
    if (!checkOutOfMoves())
    {
        if (values[row, col] == '-')
        {
            values[row, col] = player;
        }
        else
        {
            Console.WriteLine("Spot already taken...");
        }
    }
    else
    {
        Console.WriteLine("Players out of moves");
        GameOver();
    }
}


void StartGame()
{
    int row;
    int col;

    while (true)
    {
        // x
        Console.WriteLine("Placing x");

        Console.Write("Rad [0 - 2]: ");
        row = int.Parse(Console.ReadLine());

        Console.Write("Kol [0 - 2]: ");
        col = int.Parse(Console.ReadLine());

        Place(row, col, 'x');
        ShowGame();

        // o
        Console.WriteLine("Placing o");

        Console.Write("Rad [0 - 2]: ");
        row = int.Parse(Console.ReadLine());

        Console.Write("Kol [0 - 2]: ");
        col = int.Parse(Console.ReadLine());

        Place(row, col, 'o');
        ShowGame();
    }
}

void GameOver()
{
    Console.WriteLine("Game Over");
}

StartGame();