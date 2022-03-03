// 60. Составить частотный словарь элементов двумерного массива
// Показать сколько раз встречается эллемента массива (число, символ)

using static System.Console;
using System.Collections.Generic;
Clear();

Write("Vvedite znachenie visoti massiva i nazhmite Enter: ");
int x = int.Parse(ReadLine());
Write("Vvedite znachenie shirini massiva i nazhmite Enter: ");
int y = int.Parse(ReadLine());

int[,] table = new int[x, y];

WriteLine();

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        table[i, j] = new Random().Next(0, 9);
        Write($"{table[i, j] + " "}");
    }
    WriteLine();
}
WriteLine();

int summ0 = 0;
int summ1 = 0;
int summ2 = 0;
int summ3 = 0;
int summ4 = 0;
int summ5 = 0;
int summ6 = 0;
int summ7 = 0;
int summ8 = 0;
int summ9 = 0;

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        if (table[i, j] == 0) summ0 = summ0 + 1;
        if (table[i, j] == 1) summ1 = summ1 + 1;
        if (table[i, j] == 2) summ2 = summ2 + 1;
        if (table[i, j] == 3) summ3 = summ3 + 1;
        if (table[i, j] == 4) summ4 = summ4 + 1;
        if (table[i, j] == 5) summ5 = summ5 + 1;
        if (table[i, j] == 6) summ6 = summ6 + 1;
        if (table[i, j] == 7) summ7 = summ7 + 1;
        if (table[i, j] == 8) summ8 = summ8 + 1;
        if (table[i, j] == 9) summ9 = summ9 + 1;
    }
}

WriteLine($"Cifri 0 v massive {summ0}");
WriteLine($"Cifri 1 v massive {summ1}");
WriteLine($"Cifri 2 v massive {summ2}");
WriteLine($"Cifri 3 v massive {summ3}");
WriteLine($"Cifri 4 v massive {summ4}");
WriteLine($"Cifri 5 v massive {summ5}");
WriteLine($"Cifri 6 v massive {summ6}");
WriteLine($"Cifri 7 v massive {summ7}");
WriteLine($"Cifri 8 v massive {summ8}");
WriteLine($"Cifri 9 v massive {summ9}");