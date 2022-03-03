// 61. Найти произведение двух матриц

using static System.Console;

Clear();

int[,] matrix1 = { { 3, 6, 8 }, { 4, 10, 3 }, { 4, 9, 2 } };
PrintArray(matrix1);
WriteLine();
int[,] matrix2 = { { 5, 6, 2 }, { 1, 7, 3 }, { 1, 4, 3 } };
PrintArray(matrix2);
int j = 0;
WriteLine();

for (int i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        matrix1[i, j] = matrix1[i, j] * matrix2[i, j];
    }
    j = 0;
}

WriteLine("Proizvedenie matric");
PrintArray(matrix1);

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
