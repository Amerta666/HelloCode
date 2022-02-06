// 6. Выяснить является ли число чётным (Альтернативный вариант)
// using static System.Console;
// - после этого можно писать "WriteLine", а не "Console.WriteLine" в коде и.т.д 

Console.WriteLine("Введите число"); 
//string num = Console.ReadLine();
//int Number = int.Parse(num);

int Number = int.Parse(Console.ReadLine());
if (Number % 2 == 0)
{
    Console.Write(Number);
    Console.Write(" является чётным числом");
    return;
}    

Console.Write(Number);
Console.WriteLine(" является нечётным числом");

