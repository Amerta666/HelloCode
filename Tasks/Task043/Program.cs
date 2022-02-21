// 43. Написать программу преобразования десятичного числа в двоичное

using static System.Console;

int a = int.Parse(ReadLine());

int b;
string otvet = string.Empty;
while (a != 0)
{
    otvet = (a % 2).ToString() + otvet;
    a = a / 2;
}
WriteLine(otvet);






