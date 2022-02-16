//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

using static System.Console;

int[] arr =new int[8];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 2);
    Write(arr[i] + " ");
}

