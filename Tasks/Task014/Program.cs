// Задача 14: Найти третью цифру числа или сообщить, что её нет.

using static System.Console;

WriteLine("Введите число");
int number = int.Parse(ReadLine());

if (number < 100)
{
    WriteLine("Третьей цифры числа нет");
    return;
}

string Number = number.ToString();
WriteLine(GetAnswer(Number));
   
string GetAnswer(string a)
{
    int SecondNumber = int.Parse(a[2].ToString());
    return SecondNumber.ToString();
}