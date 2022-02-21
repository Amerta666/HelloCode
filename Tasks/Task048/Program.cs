// 48. Показать двумерный массив размером m×n заполненный целыми числами

using static System.Console;

WriteLine("Vvedite m");
int m = int.Parse(ReadLine());
WriteLine("Vvedite n");
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