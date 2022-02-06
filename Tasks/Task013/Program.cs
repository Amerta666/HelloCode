// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
using static System.Console;

//int FirstNumber = new Random().Next(100, 1000);
//WriteLine(FirstNumber);
//int SecondNumber = new Random().Next(10, 100);
//WriteLine(SecondNumber);
//int result = FirstNumber / SecondNumber;

//WriteLine(result); 


int a1 = int.Parse(ReadLine()); 
int a2 = int.Parse(ReadLine()); 
WriteLine(GetAnswer(a1, a2));

string GetAnswer(int a, int b)
{   
    if (a % b == 0) return $"Число {a} кратно {b}";
    return $"Число {a} не кратно {b}, остаток - {a % b}";
    //return (a % b).ToString();
}
