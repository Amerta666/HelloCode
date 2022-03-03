// 60. Составить частотный словарь элементов двумерного массива
// Показать сколько раз встречается эллемента массива (число, символ)

//                              Решение не доделано!!

using static System.Console;
using System.Linq;
using System;
Clear();

MyStruct[] resM = new MyStruct[10];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(0, 10);
    }
}

int[] rowArray = GetRowArray(array);
int el = 0;
foreach (int num in rowArray)
{
    if (resM.First(x => x.Value == num) == null) ;
}

int[] GetRowArray(int[,] ar)
{
    int m = 0;
    int[] res = new int[ar.GetLength(0) * args.GetLength(1)];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(0); j++)
        {
            res[m] = ar[i, j];
            m++;
        }
    }
    return res.OrderBy(x => x).ToArray();
}

void PrintArray(int[,] a)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Write($"{a[i,j]} ");
        }
        WriteLine();
    }
}

struct MyStruct
{
    public int Value;
    public int Count;
}