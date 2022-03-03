// **Задача 65:** Спирально заполнить двумерный массив:

using static System.Console;

Clear();

int m = 5;
int n = 5;
int s = m * n;
int[,] matrix = new int[m, n];

for (int y = 0; y < n; y++)
{
    matrix[0, y] = s;
    s--;
}
for (int x = 1; x < m; x++)
{
    matrix[x, n - 1] = s;
    s--;
}
for (int y = n - 2; y >= 0; y--)
{
    matrix[m - 1, y] = s;
    s--;
}
for (int x = m - 2; x > 0; x--)
{
    matrix[x, 0] = s;
    s--;
}

int c = 1;
int d = 1;

while (s > 1)
{
    while (matrix[c, d + 1] == 0)
    {
        matrix[c, d] = s;
        s--;
        d++;
    }
    while (matrix[c + 1, d] == 0)
    {
        matrix[c, d] = s;
        s--;
        c++;
    }
    while (matrix[c, d - 1] == 0)
    {
        matrix[c, d] = s;
        s--;
        d--;
    }
    while (matrix[c - 1, d] == 0)
    {
        matrix[c, d] = s;
        s--;
        c--;
    }
}

for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (matrix[x, y] == 0)
        {
            matrix[x, y] = s;
        }
    }
}

for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (matrix[x,y] < 10)
        {
            PrintArray(matrix);
        }
        else
        {
            PrintArray(matrix);
        }
    }
    WriteLine();
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
        WriteLine();
    }
}