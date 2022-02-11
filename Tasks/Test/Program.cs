using static System.Console;
using ClassLib;

int a = int.Parse(ReadLine());
int b = int.Parse(ReadLine());

string GetAnswer(int a, int b)
{
    string answer = a == b * b ? "a квадрат b":b==a*a? "b квадрат a":"a и b не квадраты друг другу";
    return answer;
}

WriteLine(GetAnswer(a, b));

// int b, c;
// c = -4;
// b = c >= 0 ? c : c*c;   // b = 16

//WriteLine(b);