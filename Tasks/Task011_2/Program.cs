// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
using static System.Console;

WriteLine("Введите число от 10 до 99");
string Number = ReadLine();
int FirstNumber = int.Parse(Number[0].ToString());
int SecondNumber = int.Parse(Number[1].ToString());
int Max = FirstNumber;
if (SecondNumber > Max) Max = SecondNumber;

Write("Наибольшая цифра введённого числа - ");
WriteLine(Max);