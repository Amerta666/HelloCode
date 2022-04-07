// 67: Задайте значения M и N. 
//     Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

using static System.Console;

Write("Vvedite m: ");
int m = int.Parse(ReadLine());
Write("Vvedite n: ");
int n = int.Parse(ReadLine());
WriteLine();

string NumbersRec(int m, int n)
{
    if (n > m) return $"{m} " + NumbersRec(m + 1, n);
    if (n < m) return $"{m} " + NumbersRec(m - 1, n);
    else return $"{m} ";
}

WriteLine(NumbersRec(m, n));
