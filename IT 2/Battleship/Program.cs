using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

int[,] player1 = new int[10, 10];
int[,] player2 = new int[10, 10];

Dictionary<string, int> ships = new Dictionary<string, int>
{
    { "Carrier",    5 },
    { "Battleship", 4 },
    { "Cruiser",    3 },
    { "Submarine",  3 },
    { "Destroyer",  2 },
};

void PlaceShips(int[,] player)
{
    Dictionary<string, int> playerShips = new Dictionary<string, int>(ships);

    Console.WriteLine($"Placing ships for player:");

    foreach (KeyValuePair<string, int> pair in playerShips)
    {
        bool placed = false;

        ShowBoard(player);

        while (!placed)
        {
            Console.WriteLine($"Currently placing {pair.Key}, which occupies {pair.Value} tiles");

            Console.Write($"Placing tip of {pair.Key}:\nRow (0-9): ");
            int shipRow = int.Parse(Console.ReadLine());

            Console.Write($"Column (0-9): ");
            int shipCol = int.Parse(Console.ReadLine());

            Console.Write("(V)ertical or (H)orizontal: ");
            char direction = char.Parse(Console.ReadLine().ToUpper());

            if (CheckEmpty(shipRow, shipCol, player, direction, pair.Value))
            {
                // Place the ship
                for (int i = 0; i < pair.Value; i += 1)
                {
                    if (direction == 'V')
                    {
                        player[shipRow + i, shipCol] = 1;
                    }
                    else
                    {
                        player[shipRow, shipCol + i] = 1;
                    }
                }

                placed = true;
            }
            else
            {
                Console.WriteLine("Invalid placement. Try again.");
            }
        }
    }
}

bool CheckEmpty(int row, int col, int[,] player, char direction, int shipLength)
{
    // Out of bounds
    if (direction == 'V' && row + shipLength > 10)
    {
        return false;
    }
    else if (direction == 'H' && col + shipLength > 10)
    {
        return false;
    }

    // Overlap
    for (int i = 0; i < shipLength; i++)
    {
        if (direction == 'V')
        {
            if (player[row + i, col] != 0)
            {
                return false;
            }
        }
        else
        {
            if (player[row, col + i] != 0)
            {
                return false;
            }
        }
    }
    return true;
}

void ShowBoard(int[,] player)
{
    for (int i = 0; i < player.GetLength(0); i++)
    {
        for (int j = 0; j < player.GetLength(1); j++)
        {
            Console.Write(player[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PlaceShips(player1);
