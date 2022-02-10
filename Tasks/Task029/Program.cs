// Написать программу вычисления произведения чисел от 1 до N
using static System.Console;

WriteLine("Введите число");
int N = int.Parse(ReadLine());  
int sum = 1;              

for (int i = 1; i <= N; i++)
{                   
    sum = i * sum;
    WriteLine(sum);
}