// 15. Дано число. Проверить кратно ли оно 7 и 23

using static System.Console;

WriteLine("Введите число");
int Number = int.Parse(ReadLine());

if (Number % 23 == 0) WriteLine (Number + " кратно 23");
    else WriteLine (Number + " не кратно 23");
if (Number % 7 == 0) WriteLine (Number + " кратно 7");
    else WriteLine (Number + " не кратно 7");