// 2. Даны два числа. Показать большее и меньшее число
string sa = Console.ReadLine();
string sb = Console.ReadLine();
int  FirstNumber = int.Parse(sa);
int SecondNumber = int.Parse(sb);
if (FirstNumber > SecondNumber) 
{ 
    Console.Write(FirstNumber); 
    Console.WriteLine(" является большим числом");
    Console.Write(SecondNumber); 
    Console.Write(" является меньшим");
}
else 
{
    Console.Write(second_number); 
    Console.WriteLine(" является большим числом");
    Console.Write(first_number); 
    Console.Write(" является меньшим");
}
