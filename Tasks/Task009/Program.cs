// 9. Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трёхзначное число");

int number = int.Parse(Console.ReadLine());

Console.Write("Последняя цифра введённого числа - ");
Console.WriteLine(number % 10);