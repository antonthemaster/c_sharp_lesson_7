/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int m = new Random().Next(1, 7);
int n = new Random().Next(1, 7);
Console.WriteLine(m);
Console.WriteLine(n);

int [,] array_2d = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array_2d[i, j] = i + j;
        Console.Write(Convert.ToString(array_2d[i, j]) + ' ');
    }
    Console.WriteLine();
}
