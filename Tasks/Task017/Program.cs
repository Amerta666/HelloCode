// 17. По двум заданным числам проверять является ли одно квадратом другого

using static System.Console;

WriteLine("Введите первое число");
int number1 = int.Parse(ReadLine());

WriteLine("Введите второе число");
int number2 = int.Parse(ReadLine());
//int number1 = 3;
//int number2 = 9;
WriteLine(GetAnswer(number1, number2));



string GetAnswer(int a, int b)
{
    if (a == b * b) return $"Число {a} является квадратом {b}";
    if (b == a * a) return $"Число {b} является квадратом {a}";
    return $"Ни одно число не является квадратом другого";
}