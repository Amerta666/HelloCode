// 68. Показать натуральные числа от M до N, N и M заданы

using static System.Console;

WriteLine("Vvedite M: ");
int m = int.Parse(ReadLine());
WriteLine("Vvedite N: ");
int n = int.Parse(ReadLine());

string NumbersRec(int a, int b)
{
    if (a == b) return b.ToString();
    else return b.ToString() + " " + NumbersRec(a, ++b);
}

WriteLine(NumbersRec(n, m));