
// Посчитать количество цифр в слове

using static System.Console;
using ClassLib;

int N = int.Parse(ReadLine());
int[] arr = new int[N].Select(x => new Random().Next(1, 100)).ToArray();

WriteLine(String.Join(" ", arr));
