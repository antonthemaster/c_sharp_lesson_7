double [] get_average_for_rows(int[,] array)
{
    double [] result = new double [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double row_sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row_sum += array[i, j];
        }
        result[i] = Math.Round(row_sum / array.GetLength(1), 1);
    }
    return result;
}


int m = new Random().Next(4, 7);
int n = new Random().Next(3, 7);
Console.WriteLine(m);
Console.WriteLine(n);
Console.WriteLine();
int [,] array_2d = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array_2d[i, j] = new Random().Next(0, 9);
        Console.Write(Convert.ToString(array_2d[i, j]) + ' ');
    }
    Console.WriteLine();
}
Console.WriteLine();
double [] result = get_average_for_rows(array_2d);
Console.WriteLine(String.Join(" ", result));
