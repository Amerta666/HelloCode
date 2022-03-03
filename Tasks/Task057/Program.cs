// **Задача 57:** Написать программу, которая упорядочивает 
//   по убыванию элементы каждой строки двумерного массива.

using static System.Console;

Clear();

WriteLine("Vvedite chislo strok matrici");
int m = int.Parse(ReadLine());
WriteLine("Vvedite chislo stolbcov matrici");
int n = int.Parse(ReadLine());

int[,] matrix = new int[m, n];
int temp = matrix[0, 0];

FillArray(matrix);
PrintArray(matrix);
SortArray(matrix);
WriteLine();
PrintArray(matrix);

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
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

int[,] SortArray(int[,] matrix)
{
    for (int k = 0; k <= (m * n); k++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
    return matrix;
}