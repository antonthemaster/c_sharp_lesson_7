int [,] array_2d = new int [3, 4];

for (int i = 0; i < array_2d.GetLength(0); i++)
{
    for (int j = 0; j < array_2d.GetLength(1); j++)
    {
        array_2d[i, j] = new Random().Next(10);
        Console.Write(array_2d[i, j] + ' ');
    }
    Console.WriteLine();
}

