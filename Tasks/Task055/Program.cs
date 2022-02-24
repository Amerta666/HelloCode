// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

using static System.Console;

Clear();

WriteLine("Vvedite m");
int m = int.Parse(ReadLine());
WriteLine("Vvedite n");
int n = int.Parse(ReadLine());
WriteLine("Vvedite iskomoe chislo");

int[,] matrix = new int[m, n];
int[] summ = new int[n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);
        Write($"{matrix[i, j]} ");
    }
    WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {           
        summ[i] += matrix[j, i];
    } 
}
WriteLine();
foreach (double elem in summ)
{           
    WriteLine(elem/n);
}