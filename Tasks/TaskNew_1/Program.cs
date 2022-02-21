// Проверить является строка номером машины!
// Х000ХХ
// A, B, C, E, H, K, M, O, P, T, X, Y

using static System.Console;
using System.IO;
using System;
using System.Linq;

StreamReader sr=new StreamReader("input");
int yes=0;
int i=0;
string chars="0123456789ABCEHKMOPTXYАВСЕНКМОРТХУ";
while(!sr.EndOfStream)
{
    string number = sr.ReadLine();
    if((chars.IndexOf(number[0])>9)
    &&(chars.IndexOf(number[1])<9)
    &&(chars.IndexOf(number[2])<9)
    &&(chars.IndexOf(number[2])>=0)
    &&(chars.IndexOf(number[3])<9)
    &&(chars.IndexOf(number[3])>=0)
    &&(chars.IndexOf(number[4])>9)
    &&(chars.IndexOf(number[4])>=0)
    &&(chars.IndexOf(number[5])>9)
    ) yes++;
    i++;
}

Console.WriteLine($"{yes}  {i-yes}");