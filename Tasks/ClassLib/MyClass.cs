namespace ClassLib;
public class MyClass
{
    
    
    ///<summary>
    /// Получить массив с указанным размером
    ///</summary>
    static public int[] GetArray(int size)
    {   
        int[] ar = new int[size];
        for (int i = 0; i < size; i++)
        {
            ar[i] = new Random().Next(10, 100);
        }
        return ar;
    }

    ///<summary>
    /// Получить массив с указанным размером в указанном диапазоне
    ///</summary>
    static public int[] GetArray(int size, int minValue, int maxValue)
    {   
        int[] ar = new int[size];
        for (int i = 0; i < size; i++)
        {
            ar[i] = new Random().Next(minValue, maxValue);
        }
        return ar;
    }

}
