// 28. Подсчитать сумму цифр в числе

using static System.Console;

WriteLine("Enter a positive number");
int aNum = int.Parse(ReadLine());
int sum = 0;

while (aNum > 0)
{
    sum = sum + aNum % 10;
    aNum = aNum / 10;
}
WriteLine("The sum of the digits of the number is " + sum);

