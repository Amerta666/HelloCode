// Задать массив из 8 элементов и вывести их на экран(вводим руками)
using static System.Console;

//using static System.Console;

int[] MyArray = new int[3];
MyArray[0] = int.Parse(ReadLine());
MyArray[1] = int.Parse(ReadLine());
MyArray[2] = int.Parse(ReadLine());
WriteLine($"{MyArray[0]} {MyArray[1]} {MyArray[2]}");
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
//PrintArray(MyArray);
//Console.WriteLine("Введите размерность массива:");
//int i, n = Convert.ToInt32(Console.ReadLine());
//int[] mas = new int[n];
//Console.WriteLine("Введите массив:");
//string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//for (i = 0; i < (n < str.Length ? n : str.Length); ++i)
//    mas[i] = Convert.ToInt32(str[i]);
//Console.WriteLine("Введенный массив:");
//for (i = 0; i < n; ++i)
//   Console.Write("{0} ", mas[i]);


