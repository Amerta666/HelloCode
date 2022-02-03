//  1. По двум заданным числам проверять является ли первое квадратом второго
string sa = Console.ReadLine();
string sb = Console.ReadLine();
int first_number = int.Parse(sa);
int second_number = int.Parse(sb);
if (second_number * second_number == first_number) Console.Write("Первое число является квадратом второго");
else Console.Write("Первое число НЕ является квадратом второго");

