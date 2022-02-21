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
string name1 = names[0].ToString().ToLower().Select(x => (byte)x).OrderBy(x => x).ToString();
string name2 = names[1].ToString().ToLower().Select(x => (byte)x).OrderBy(x => x).ToString();
Console.WriteLine(name1);
Console.WriteLine(name2);
if (name1.Length != name2.Length)
{
    Console.WriteLine("No!");
    return;
}

if(name1.Equals(name2)) Console.WriteLine("Yes!"); else
{
    Console.WriteLine("No");
};



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