// 45. Показать числа Фибоначчи


using static System.Console;

int N = int.Parse(ReadLine());

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < N + 1; i++)      // 10 - число до которого считать
{
    WriteLine(Fibonacci(i));
}