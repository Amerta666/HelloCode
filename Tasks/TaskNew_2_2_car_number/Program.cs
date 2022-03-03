// Harry Potter
//Если Вы читали Гарри Поттера, то знаете, что повелитель зла, 
//Лорд Волдеморт создал свое имя путем перестановки букв в своем настоящем имени. 
//Так из имени «TomMarvoloRiddle» он получил «IamLordVoldemort».
//Напишите программу, которая проверяет, 
//можно ли получить из одного имени другое путем перестановки его букв. 
//При этом регистром букв нужно пренебречь.

using System.IO;
using System;
using System.Linq;

StreamReader sr = new StreamReader("input");
string[] names = sr.ReadLine().Split(" ");
byte[] name1 = names[0].ToString().ToLower().Select(x => (byte)x).OrderBy(x => x).ToArray();
byte[] name2 = names[1].ToString().ToLower().Select(x => (byte)x).OrderBy(x => x).ToArray();
if (name1.Count() != name2.Count())
{
    Console.WriteLine("No!");
    return;
}
for (int i = 0; i < name1.Count(); i++)
{
    if (name1[i] != name2[i])
    {
        Console.WriteLine("No!");
        return;
    }
}
Console.WriteLine("Yes!");



//Console.WriteLine(res);
/*int yes=0;
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

Console.WriteLine($"{yes}  {i-yes}");*/
