// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
//     Показать количество нечетных\четных чисел

using static System.Console;

WriteLine("Vvedite razmer massiva");
int N = int.Parse(ReadLine());
int[] arr = new int[N];
int chetnie = 0;
int neChetnie = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 999);
}
WriteLine("Poluchaem massiv ");
WriteLine(String.Join(" ",arr));

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0) chetnie++; 
    else neChetnie++;
}
WriteLine($"Kolichestvo chetnih - " + chetnie);
WriteLine($"Kolichestvo neChetnih - " + neChetnie);