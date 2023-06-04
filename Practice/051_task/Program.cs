
/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int [,] array_2d = new int [6, 5];
int res = 0;

for (int i = 0; i < array_2d.GetLength(0); i++)
{
    for (int j = 0; j < array_2d.GetLength(1); j++)
    {
        array_2d[i, j] = new Random().Next(10);
        Console.Write(array_2d[i, j] + " ");
        if (i == j)
        {
            res += array_2d[i, j];
        }
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.Write(res);
