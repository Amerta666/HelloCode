// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

using static System.Console;


WriteLine("Vvedite razmer massiva");
int N = int.Parse(ReadLine());
int[] arr = new int[N];
int sumNechetnih = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 99);
}
WriteLine("Poluchaem massiv");
WriteLine(String.Join(" ", arr));

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0) sumNechetnih += arr[i];
}

WriteLine("Summa chisel na nechetnih poziciyah - " + sumNechetnih);