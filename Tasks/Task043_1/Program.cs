// 43. Написать программу преобразования десятичного числа в двоичное

using static System.Console;

Clear();

WriteLine("Vvedite desyatichnoe chislo");
int number = int.Parse(ReadLine());
WriteLine("Vvedite osnovanie sistemi ischisleniya");
int systemBase = int.Parse(ReadLine());

WriteLine(Perevod(number, systemBase));

string Perevod(int num, int sysbase)
{
    string result = string.Empty;
    if (num < sysbase) result = num.ToString() + result;
    else result = Perevod(num/sysbase, sysbase) + (num % sysbase).ToString() + result;
    return result;
}