// // 56. Написать программу, которая обменивает элементы первой строки и последней строки

using static System.Console;

Clear();

WriteLine("Vvedite chislo strok matrici");
int m = int.Parse(ReadLine());
WriteLine("Vvedite chislo stolbcov matrici");
int n = int.Parse(ReadLine());

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);

for (int i = 0; i < n; i++)
{
    (matrix[0,i], matrix[m-1,i]) = (matrix[m-1,i], matrix[0,i]);
}

WriteLine();
PrintArray(matrix);

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,100);
        }
    }
}

void PrintArray(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i,j]}");
        }
    WriteLine();    
    }
}