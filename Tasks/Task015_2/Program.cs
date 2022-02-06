// 15. Дано число. Проверить кратно ли оно 7 и 23

using static System.Console;

WriteLine("Введите число");
int a1 = int.Parse(ReadLine());
WriteLine(GetAnswer(a1));

string GetAnswer(int a)
{
    if ((a % 7 == 0) & (a % 23 == 0)) return $"Число {a} кратно и 7 и 23";
    if (a % 7 == 0) return $"Число {a} кратно 7";
    if (a % 23 == 0) return $"Число {a} кратно 23";
    return $"Число {a} не кратно 7 и 23";
}