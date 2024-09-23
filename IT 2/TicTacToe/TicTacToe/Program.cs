

// 2D-Array

using System.Data;
using System.Runtime.Serialization;

string[,] values = { { "x", "x", "x" }, { "a", "a", "a" }, { "n", "n", "n" } };

Console.WriteLine("\tKol 0\t Kol 1\t Kol 2");
Console.WriteLine($"Rad 0\t{values[0, 0]}\t {values[0, 1]}\t {values[0, 2]}");
Console.WriteLine($"Rad 1\t{values[1, 0]}\t {values[1, 1]}\t {values[1, 2]}");
Console.WriteLine($"Rad 2\t{values[2, 0]}\t {values[2, 1]}\t {values[2, 2]}");

void checkRows()
{
    int row = 0;

    while (row != 3)
    {
        if (values[row, 0] == values[row, 0 + 1] && values[row, 0] == values[row, 0 + 2])
        {
            Console.WriteLine("win");
            break;
        }
        else
        {
            row += 1;
        }
    }
}


void checkCols()
{
    int col = 0;

    while (col != 3)
    {
        if (values[0, col] == values[0 + 1, col] && values[0, col] == values[0 + 2, col])
        {
            Console.WriteLine("win");
            break;
        }
        else
        {
            col += 1;
        }
    }
}


checkRows();