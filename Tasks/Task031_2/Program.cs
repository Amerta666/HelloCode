// // Задать массив из 8 элементов и вывести их на экран 

using ClassLib;
using static System.Console;


int[] MyArray = new int[8];

for (int i = 0; i < MyArray.Length; i++)
{
    MyArray[i] = Convert.ToInt32(Console.ReadLine());
}
    
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}
PrintArray(MyArray);