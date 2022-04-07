// 69: Задайте значения M и N. 
//     Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using static System.Console;

Write("Vvedite m: ");
int m = int.Parse(ReadLine());
Write("Vvedite n: ");
int n = int.Parse(ReadLine());
WriteLine();

int Sum(int m, int n)
{
    if (m > n) return n + Sum(m, n + 1);
    if (m < n) return m + Sum(m + 1, n);
    return m;
}
WriteLine(Sum(m, n));

//return m >= n ? m : m + sum(m + 1, n);
//return m <= n ? n : n + sum(m, n + 1);