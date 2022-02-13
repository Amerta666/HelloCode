// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

using static System.Console;


WriteLine("Введите X");
int x = int.Parse(ReadLine());
WriteLine("Введите Y");
int y = int.Parse(ReadLine());
bool X = true;
bool Y = true;

if (x > 1) return;
if (y > 1) return;
if (x == 1) X = true;
if (x == 0) X = false;
if (y == 1) Y = true;
if (y == 0) Y = false;

Write("Истинность утверждения - ");
WriteLine(GetAnswer(X, Y));

bool GetAnswer (bool X, bool Y)
{
    if (!(X | Y) == !X & !Y) return true;
    else return false;
}
