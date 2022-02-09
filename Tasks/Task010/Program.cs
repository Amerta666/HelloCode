// Задача 10: Показать вторую цифру трёхзначного числа.

using static System.Console;

WriteLine("Введите трёзхначное число");
string Number = ReadLine();

WriteLine(GetAnswer(Number));
   
string GetAnswer(string a)
{
    int SecondNumber = int.Parse(a[1].ToString());
    return SecondNumber.ToString();
}