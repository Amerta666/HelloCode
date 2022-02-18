// 43. Написать программу преобразования десятичного числа в двоичное

using static System.Console;

int a = int.Parse(ReadLine());

int i, b;   
while(a !=0 )
{   b = a%2;  
    WriteLine(b);  
    a = a/2;  
}  







