using static System.Console;
namespace ClassLib;
public class MyClass
{
    public static void PrintArray(int[] array)
    {
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
    }
}
