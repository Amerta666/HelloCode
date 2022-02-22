// 42. Определить сколько чисел больше 0 введено с клавиатуры

using static System.Console;

int count = 0;

do
{
    WriteLine("Vvedite chislo");
    int N = int.Parse(ReadLine());
    WriteLine("Добавить?");
    if (N > 0) count++; 
}
while (!ReadLine().Equals("n"));

WriteLine(count);