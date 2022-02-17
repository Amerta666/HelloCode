// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
//     Показать количество нечетных\четных чисел

using static System.Console;

WriteLine("Enter the number of numbers in the array");
int N = int.Parse(ReadLine());
int[] arr = new int[N];
int even = 0;
int odd = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 999);
}
WriteLine("Given an array ");
WriteLine(String.Join(" ",arr));

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0) even++; 
    else odd++;
}
WriteLine($"Number of even numbers - " + even);
WriteLine($"Number of odd numbers - " + odd);