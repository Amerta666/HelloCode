// 2. Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите два числа");

string fn = Console.ReadLine();
string sn = Console.ReadLine();

int FirstNumber = int.Parse(fn);
int SecondNumber = int.Parse(sn);

if (FirstNumber > SecondNumber) 
{ 
    Console.Write(FirstNumber); 
    Console.WriteLine(" является большим числом");
    Console.Write(SecondNumber); 
    Console.Write(" является меньшим");
}
else 
{
    Console.Write(SecondNumber); 
    Console.WriteLine(" является большим числом");
    Console.Write(FirstNumber); 
    Console.Write(" является меньшим");
}
