// 58. Написать программу, которая в двумерном массиве 
// заменяет строки на столбцы или сообщить, что это невозможно 
// (в случае, если матрица не квадратная).

using static System.Console;


Clear();

int[,] FillArray(int rowsToFill, int columnsToFill)
{
    Random rand = new Random();
    int[,] tempArray = new int[rowsToFill, columnsToFill];

    for (int i = 0; i < rowsToFill; i++)
    {
        for (int j = 0; j < columnsToFill; j++)
        {
            tempArray[i, j] = rand.Next(0, 10);
        }
    }
    return tempArray;
}

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

WriteLine("Zadaite razmer dvumernogo massiva m*n");
Write("stroki m = ");
int rows = int.Parse(ReadLine());
Write("stolbci n = ");
int columns = int.Parse(ReadLine());

if (rows != columns)
{
    WriteLine("Vipolnenie nevozmozhno, m <> n");
    return;
}

int[,] arrayA = FillArray(rows, columns);
WriteLine("Ishodnaya matrica");
ShowArray(arrayA);

for (int i = 0; i < arrayA.GetLength(0); i++)
{
    for (int j = i + 1; j < arrayA.GetLength(1); j++)
    {
        int temp = arrayA[i,j];
        arrayA[i,j] = arrayA[j,i];
        arrayA[j,i] = temp;
    }
}

WriteLine("Transport matrix");
ShowArray(arrayA);