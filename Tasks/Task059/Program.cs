// **Задача 59:** В прямоугольной матрице найти 
//   строку с наименьшей суммой элементов.

using static System.Console;

Clear();
WriteLine("Chislo strok matrici - 6");
int m = 6;
WriteLine("Chislo stolbcov matrici - 3");
int n = 2;

int count = 0;
int result = 0;
int result2 = 0;
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
WriteLine();
PrintArray(matrix);
WriteLine();
ArrayChange(matrix);
WriteLine($"Naimenshaya summa elementov = {count}");
MinArray(matrix);


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 99);
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
void ArrayChange(int[,] matrix)
{
    count = matrix.GetLength(0) * 9;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result = result + matrix[i, j];

        }
        if (result < count)
        {
            count = result;
            result = 0;
        }
        result = 0;
    }

}
void MinArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result2 = result2 + matrix[i, j];

        }
        if (result2 == count)
        {
            WriteLine($"Stroka s naimenshei summoi elementov = {i}");
        }
        result2 = 0;
    }
}