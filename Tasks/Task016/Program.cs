// Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным

using static System.Console;

int NumberDay = int.Parse(ReadLine());
WriteLine(GetAnswer(NumberDay));

string GetAnswer(int a)
{
    if (a < 1) return $"Введённое число не является номером дня недели";
    if (a <= 5) return $"Номер дня недели не является выходным";
    if (a == 6 || a == 7) return $"Номер дня недели является выходным";
    return $"Введённое число не является номером дня недели";
}