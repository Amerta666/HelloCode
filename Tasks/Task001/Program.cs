//  1. По двум заданным числам проверять является ли первое квадратом второго
string fn = Console.ReadLine();
string sn = Console.ReadLine();
int FirstNumber = int.Parse(fn);
int SecondNumber = int.Parse(sn);
if (SecondNumber * SecondNumber == FirstNumber) Console.Write("Первое число является квадратом второго");
else Console.Write("Первое число НЕ является квадратом второго");

