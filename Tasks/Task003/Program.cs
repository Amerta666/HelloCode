// 3. По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели");
string NW = Console.ReadLine();
int NumberDayWeek = int.Parse(NW);
if (NumberDayWeek == 1) 
{   
    Console.WriteLine("Понедельник");
}
if (NumberDayWeek == 2) 
{   
    Console.WriteLine("Вторник");
}
if (NumberDayWeek == 3) 
{   
    Console.WriteLine("Среда");
}
if (NumberDayWeek == 4) 
{   
    Console.WriteLine("Четверг");
}
if (NumberDayWeek == 5) 
{   
    Console.WriteLine("Пятница");
}
if (NumberDayWeek == 6) 
{   
    Console.WriteLine("Суббота");
}
if (NumberDayWeek == 7) 
{   
    Console.WriteLine("Воскресенье");
}
if (NumberDayWeek > 7) 
{   
    Console.WriteLine("Введите значение от 1 до 7");
}