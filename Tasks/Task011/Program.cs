// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Введите число от 10 до 99");
int number = int.Parse(Console.ReadLine());
int FirstNumber = number % 10;
int SecondNumber = number / 10;

int MaxNumber = FirstNumber;
if (SecondNumber > FirstNumber) MaxNumber = SecondNumber;

Console.Write("Наибольшая цифра числа - ");
Console.WriteLine(MaxNumber);