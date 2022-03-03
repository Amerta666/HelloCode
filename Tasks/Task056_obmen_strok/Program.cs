// 56. Написать программу, которая обменивает элементы первой строки и последней строки

using static System.Console;


Clear();

WriteLine("Vvedite m");
int m = int.Parse(ReadLine());
WriteLine("Vvedite n");
int n = int.Parse(ReadLine());

int[,] matrix = new int[m, n];
int temp = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(100);
        Write($"{matrix[i, j]} ");
    }
    WriteLine();
}
WriteLine();
for (int j = 0; j < matrix.GetLength(1); j++)
{
    temp = matrix[0, j];
    matrix[0, j] = matrix[n - 1, j];
    matrix[n - 1, j] = temp;
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Write($"{matrix[i, j]} ");
    }
    WriteLine();
}
