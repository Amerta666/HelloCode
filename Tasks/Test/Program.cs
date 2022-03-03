// Игра в пирамидки

using static System.Console;
using ClassLib;

int[] array = { 10, 2, 1, 3, 8, 9, 18, 43 };

for (int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] > array[minPosition])
        {
            minPosition = j;
        }
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
}

WriteLine(String.Join(" ", array));