// В указанном диапазоне, вывести все взаимнопростые числа(не кратные заданному числу - N) заданному числу
//  от А до В, N

using static System.Console;

Clear();

WriteLine("Vvedite pervoe chislo");
int firstNumber = int.Parse(ReadLine());
WriteLine("Vvedite vtoroe chislo");
int secondNumber = int.Parse(ReadLine());
WriteLine("Vvedite cratoe chislo");
int n = int.Parse(ReadLine());

string Cratnost(int a, int b, int n)
{
    int i = b - a;
    if (i == 0)
    {
        if (b % n != 0)
            return b.ToString();
        else return "";
    }
    else
    {
        if (a % n != 0 && n % a != 0) return a.ToString() + " " + Cratnost(a + 1, b, n);
        else return Cratnost(a + 1, b, n);
    }

}

WriteLine(Cratnost(firstNumber, secondNumber, n));