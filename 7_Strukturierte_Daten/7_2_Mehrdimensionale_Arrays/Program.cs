using System;
using static System.Console;

//string[,] spielfeld = new string[3, 3];

var spielfeld = new string[4, 4]
{
    { "", "A", "B", "C" },
    { "1", "#", "#", "#" },
    { "2", "#", "#", "#" },
    { "3", "#", "#", "#" }
};

for (int i = 0; i < spielfeld.GetLength(0); i++)
{
    for (int j = 0; j < spielfeld.GetLength(1); j++)
    {
        Write(spielfeld[i, j]);
    }
    WriteLine();
}
