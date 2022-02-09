// Задача 12: Удалить вторую цифру трёхзначного числа.

using static System.Console;

WriteLine("Введите трёхзначное число");
string Number = ReadLine();

WriteLine(GetAnswer(Number));
   
string GetAnswer(string a)
{
    int FirstNumber = int.Parse(a[0].ToString());
    int ThirdNumber = int.Parse(a[2].ToString());
    return FirstNumber.ToString() + ThirdNumber.ToString();
    
}