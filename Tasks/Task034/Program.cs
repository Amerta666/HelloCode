// 34. Написать программу замену элементов массива на противоположные
//     (с первого на последний и так далее, по индексу)

using static System.Console;

WriteLine("Vvedite razmer massiva");
int numbersArray = int.Parse(ReadLine());
WriteLine("Vvedite minumalniy diapazon");
int minValue = int.Parse(ReadLine());
WriteLine("Vvedite maximalniy diapazon");
int maxValue = int.Parse(ReadLine());

int[] arr = new int[numbersArray];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(minValue, maxValue);
}

WriteLine(string.Join(" ",arr));

int lastInd = arr.Length - 1;
int firstInd = 0;;
int temp = 0;                                     
while (firstInd < lastInd)
{   
    temp = arr[firstInd];
    arr[firstInd] = arr[lastInd];
    arr[lastInd] = temp;
    firstInd++;
    lastInd--;                    
}
WriteLine(String.Join(" ", arr));