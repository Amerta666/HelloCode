// 27. Определить количество цифр в слове(1 до 9).
using static System.Console;

WriteLine("Введите текст");
string text = ReadLine();
int count = 0;

for (int i = 0; i < text.Length; i++)
{
    if (Char.IsDigit(text[i])) count ++;
}

if (count == 0) WriteLine("В тексте нет цифр");
else WriteLine("В строке есть цифры их количество - " + count.ToString());