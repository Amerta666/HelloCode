// 20. Задать номер четверти, показать диапазоны для возможных координат

using static System.Console;

WriteLine("Введите номер четверти од 1 до 4");
int number = Convert.ToInt32(ReadLine());
WriteLine(GetAnswer(number));

string GetAnswer(int a)
{
    if (a == 1) return $"x > 0, y > 0";
    if (a == 2) return $"x > 0, y < 0";
    if (a == 3) return $"x < 0, y < 0";
    if (a == 4) return $"x < 0, y > 0";
    return $"Ошибка ввода. Введите номер четверти от 1 до 4";
}
