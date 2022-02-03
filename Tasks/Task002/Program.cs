// 2. Даны два числа. Показать большее и меньшее число
string sa = Console.ReadLine();
string sb = Console.ReadLine();
int first_number = int.Parse(sa);
int second_number = int.Parse(sb);
if (first_number > second_number) 
{ 
    Console.Write(first_number); 
    Console.WriteLine(" является большим числом");
    Console.Write(second_number); 
    Console.Write(" является меньшим");
}
else 
{
    Console.Write(second_number); 
    Console.WriteLine(" является большим числом");
    Console.Write(first_number); 
    Console.Write(" является меньшим");
}
