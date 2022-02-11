namespace ClassLib;
public class MyClass
{
        pubic static int[] GetArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.size; i++)
        {
        arr[i] = new Random().Next(10, 100);
        }
        return arr;
    }


    
}
