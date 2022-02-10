// 27. Определить количество цифр в слове(1 до 9).

using static System.Console;

string text = ReadLine();
int count = 0;
int number;

for (int i = 0; i < text.Length; i++)
{
    if (int.TryParse(text[i].ToString(), out number)) count++;
}
WriteLine($"Количество цифр {count}");