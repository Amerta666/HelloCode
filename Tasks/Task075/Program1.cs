// 72. Есть два массива info и data. 
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
// Числа идут друг за другом без разделителей. 
// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info. 


using static System.Console;

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };


int Stepen(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

int DvaVDesyatuyu(int[] numberDv)
{
    int numberDes = 0;
    for (int j = numberDv.Length; j > 0; j--)
    {
        numberDes += numberDv[^j] * Stepen(2, j - 1);
    }
    return numberDes;
}

int[] Perevod(int[] data, int[] info)
{
    int[] result = new int[info.Length];

    int dlinna = 0;
    for (int i = 0; i < info.Length; i++)
    {
        dlinna += info[i];
    }
    if (data.Length != dlinna)
    {
        WriteLine("Ne te parametri");
        return result;
    }

    int count = 0;
    for (int i = 0; i < info.Length; i++)
    {
        int[] arrayA = new int[info[i]];
        for (int j = 0; j < info[i]; j++)
        {
            arrayA[j] = data[j + count];
            
        }
        WriteLine(String.Join(" ", arrayA));
        result[i] = DvaVDesyatuyu(arrayA);
        count += info[i];
    }
    return result;
    
}
WriteLine(String.Join(" ", Perevod(data, info)));