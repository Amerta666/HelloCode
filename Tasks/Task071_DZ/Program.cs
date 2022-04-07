// 71: Напишите программу вычисления функции 
//     Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//     m = 2, n = 3 -> A(m,n) = 29

using static System.Console;

UInt64 m = 2;
UInt64 n = 3;

UInt64 AckermannFunc(UInt64 m, UInt64 n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermannFunc(m - 1, 1);
    else if (m > 0 && n > 0) return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    return m;
}
WriteLine(AckermannFunc(m, n));
