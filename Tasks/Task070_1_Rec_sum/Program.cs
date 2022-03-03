// 70. Найти сумму цифр числа

using static System.Console;

Clear();

WriteLine("Vvedite number");
int number = int.Parse(ReadLine());

int Sum(int num)
{
    return num < 10 ? num : num % 10 + Sum(num / 10);
}
WriteLine(Sum(number).ToString());
