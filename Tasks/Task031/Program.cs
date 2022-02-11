// Задать массив из 8 элементов и вывести их на экран 
using static System.Console;

int[] MyArray = new int[8];

for (int i = 0; i < MyArray.Length; i++)
{
    MyArray[i] = new Random().Next(10, 30);
    WriteLine(MyArray[i]);
}