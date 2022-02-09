// Задача 10: Показать вторую цифру трёхзначного числа.

using static System.Console;

WriteLine("Введите трёзхначное число");
//int number = int.Parse(ReadLine());

//if (number > 999 || number < 100)
//{
//    WriteLine("Ошибка ввода, введите ТРЁХЗНАЧНОЕ ЧИСЛО !!!");
//   return;
//}

//string Number = number.ToString();
string Number = ReadLine();
WriteLine(GetAnswer(Number));
   
string GetAnswer(string a)
{
    int SecondNumber = int.Parse(a[1].ToString());
    return SecondNumber.ToString();
}