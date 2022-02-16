// 26. Возведите число А в натуральную степень B используя цикл

using static System.Console;


WriteLine("Enter number A");
int A = int.Parse(ReadLine());
WriteLine("Enter number B");
int B = int.Parse(ReadLine());
int result = 1;

for (int i = 1; i <= B; i++)
{
    result = result * A;
    WriteLine($"{result} * {A} = {result}" );
}
WriteLine($"The number {A} to the power of {B} is {result}");