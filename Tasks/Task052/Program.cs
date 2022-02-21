// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

using static System.Console;

Clear();

WriteLine("Vvedite n");
int m = int.Parse(ReadLine());
WriteLine("Vvedite k");
int n = int.Parse(ReadLine());

int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(100);      
        Write($"{matrix[i, j]} ");
    }
    WriteLine();
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0) matrix[i, j] = matrix[i, j] * matrix[i, j];
        Write($"{matrix[i, j]} ");
    }
    WriteLine();
}