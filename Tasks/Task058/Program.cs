// 58. Написать программу, которая в двумерном массиве 
// заменяет строки на столбцы или сообщить, что это невозможно 
// (в случае, если матрица не квадратная).

using static System.Console;


Clear();

WriteLine("Vvedite m");
int m = int.Parse(ReadLine());
WriteLine("Vvedite n");
int n = int.Parse(ReadLine());

if (m != n)
{
    WriteLine("Matriza ne kvadrataya");
    return;
}

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

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp =   matrix[i , j];
        matrix[i,j] = matrix[j,i];
        matrix[j,i] = temp;
        Write($"{matrix[i, j]} ");
    }
    WriteLine();
}