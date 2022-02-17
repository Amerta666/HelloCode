// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
//     Найти сумму положительных/отрицательных элементов массива

using static System.Console;

int[] arr = new int[12];
int SumOfPositive = 0;
int SumOfNegative = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10);
}
WriteLine("Given an array ");
WriteLine(String.Join(" ", arr));

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 0) SumOfPositive += arr[i];
    else SumOfNegative += arr[i];
}

WriteLine("Sum Of Positive - " + SumOfPositive);
WriteLine("Sum Of Negative - " + SumOfNegative);