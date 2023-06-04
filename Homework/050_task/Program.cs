int m = new Random().Next(1, 7);
int n = new Random().Next(1, 7);
Console.WriteLine(m);
Console.WriteLine(n);

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

Console.Write("Enter elem to find: ");
int user_number = Convert.ToInt32(Console.ReadLine());
bool result = false;
int[] positions = new int [2];

for (int i = 0; i < array_2d.GetLength(0); i++)
{
    for (int j = 0; j < array_2d.GetLength(1); j++)
    {
        if (array_2d[i,j] == user_number)
        {
            result = true;
            positions[0] = i;
            positions[1] = j;
        }
    }
}

if (result)
{
    Console.WriteLine($"Here! => {positions[0]}, {positions[1]}");
}
else
{
    Console.WriteLine("Nope");
}



