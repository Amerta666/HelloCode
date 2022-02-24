// 53. В двумерном массиве показать позиции числа, 
//     заданного пользователем или указать, что такого элемента нет

using static System.Console;

WriteLine("Vvedite m");
int m = int.Parse(ReadLine());
WriteLine("Vvedite n");
int n = int.Parse(ReadLine());
WriteLine("Vvedite iskomoe chislo");
int chislo = int.Parse(ReadLine());

int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);
        Write($"{matrix[i, j]} ");
    }
    WriteLine();
}

bool found = false;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == chislo)
        {
            WriteLine($"Zadannoe chislo nahoditsya na {i}, {j}");
            found = true;
        }
    }
}

if (!found) WriteLine("Zadannoe chislo ne naideno");