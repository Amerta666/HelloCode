// 58. Написать программу, которая в двумерном массиве 
// заменяет строки на столбцы или сообщить, что это невозможно 
// (в случае, если матрица не квадратная).

using static System.Console;

Clear();

int n = int.Parse(ReadLine());
int m = int.Parse(ReadLine());

if (n != m)
{
    WriteLine("No!");
    return;
}

int[,] array = new int[n, n];

int[,] arrayNew = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(10, 99);
        arrayNew[j, i] = array[i, j];
    }
}

ShowArray(array);
WriteLine();
ShowArray(arrayNew);

void ShowArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Write($"{inputArray[i, j]} ");
        }
        WriteLine();
    }
}
