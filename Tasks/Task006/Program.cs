// 6. Выяснить является ли число чётным
Console.WriteLine("Введите число");
string num = Console.ReadLine();  // int Number = int.Parse(Console.ReadLine()); 
int Number = int.Parse(num);
if (Number % 2 == 0)
{
    Console.Write(Number);
    Console.Write(" является чётным числом");
}    
else 
{   
    Console.Write(Number);
    Console.WriteLine(" является нечётным числом");
}

