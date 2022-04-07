// 73. Написать программу показывающие первые N чисел, для которых 
//     каждое следующее равно сумме двух предыдущих. Первые два элемента 
//     последовательности задаются пользователем

using static System.Console;

Clear();

int N = 10;
WriteLine("Vvedite pervoe chislo");
int a = int.Parse(ReadLine());
WriteLine("Vvedite vtoroe chislo");
int b = int.Parse(ReadLine());

void ShowNumber(int a, int b, int n)
{
    int c;
    if (n > 0)
    {
        c = a + b;
        a = b;
        b = c;
        WriteLine(c);
        n--;
        ShowNumber(a, b, n);
    }
}
WriteLine();
ShowNumber(a, b, N);
