// 30. Показать кубы чисел, заканчивающихся на четную цифру

using static System.Console;

int N = int.Parse(ReadLine());
int res = 0;

for (int i = 1; i <= N; i++)
{
    res = i * i * i; 
    if (res % 2 == 0) WriteLine($"{i} * {i} * {i} = {res}");
}
