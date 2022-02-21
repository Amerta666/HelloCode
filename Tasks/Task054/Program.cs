// 54. В матрице чисел найти сумму элементов главной диагонали

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
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {   
        if (i == j)
        sum = matrix[i, j] + sum;
    }
}
WriteLine(sum);