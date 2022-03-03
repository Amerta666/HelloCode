// 66. Показать натуральные числа от 1 до N, N задано

using static System.Console;

WriteLine("Vvedite N: ");
int N = int.Parse(ReadLine());

string NumbersRec(int a, int b)
{
    if (a < b) return $"{a} " + NumbersRec(a + 1, b);
    else return $"{a} ";
}

WriteLine(NumbersRec(1, N));