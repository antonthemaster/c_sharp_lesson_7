int m = new Random().Next(1, 7);
int n = new Random().Next(1, 7);
Console.WriteLine(m);
Console.WriteLine(n);

double [,] array_2d = new double[m, n];
double low_range = -10;
double high_range = 10;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array_2d[i,j] = Math.Round(new Random().NextDouble() * (high_range - low_range) + low_range, 1);
        Console.Write(array_2d[i, j] + " ");
    }
    Console.WriteLine();
}
