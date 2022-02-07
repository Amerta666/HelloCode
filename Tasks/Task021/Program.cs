// 21. Программа проверяет пятизначное число на палиндромом.

using static System.Console;

WriteLine("Введите пятизначное число");
string Number = ReadLine();
int FirstNumber = int.Parse(Number[0].ToString());
int FifthNumber = int.Parse(Number[4].ToString());
if (FirstNumber != FifthNumber) 
{
    WriteLine("Число не является палиндромом");
}
else WriteLine("Число является палиндромом");