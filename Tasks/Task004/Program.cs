// 4. Найти максимальное из трех чисел

Console.WriteLine("Введите первое число");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int ThirdNumber = int.Parse(Console.ReadLine());

int Max = FirstNumber;
if (SecondNumber > Max) Max = SecondNumber;
if (ThirdNumber > Max) Max = ThirdNumber;

Console.Write(Max);
Console.WriteLine(" это максимальное из трёх чисел");