// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n 
// (каждый элемент массива есть сумма номера столбца и строки)
// 01234
// 12345
// 23456
// 34567
//противоположное число это число, которое дает в сумме с исходным 0.  
//Т.е замена должна выглядеть как matrix[i, j] = matrix[i, j] * (-1) или matrix[i, j] = 0- matrix[i, j]

using static System.Console;

Clear();

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

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = i + j;
        Write($"{matrix[i, j]} ");
    }
    WriteLine();
}