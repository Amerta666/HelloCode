// 40. В Указанном массиве вещественных чисел 
//     найдите разницу между максимальным и минимальным элементом

using static System.Console;

WriteLine("Vvedite razmer massiva");
int N = int.Parse(ReadLine());
int[] arr = new int[N];
WriteLine("Vvedite minimalniy diapazon");
int a = int.Parse(ReadLine());
WriteLine("Vvedite maximalniy diapazon");
int b = int.Parse(ReadLine());
WriteLine();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(a, b + 1);
}

WriteLine("Dan massiv - " + String.Join(" | ", arr));
WriteLine();
int maxElementArray = 0;
int minElementArray = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > maxElementArray) maxElementArray = arr[i];
    if (arr[i] < minElementArray) minElementArray = arr[i];
}
int result = maxElementArray - minElementArray;
WriteLine("Maximalniy element - " + maxElementArray.ToString());
WriteLine("Minimalniy element - " + minElementArray.ToString());
WriteLine();
WriteLine("Raznica maximalnogo i minimalnoro elementa - " + result);
