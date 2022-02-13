// 23. Показать таблицу квадратов чисел от 1 до N 

using static System.Console;

int N = int.Parse(ReadLine());

for (int i = 1; i <= N; i++)
{
    WriteLine($"{i} * {i} = {i * i}"); 
}