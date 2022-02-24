using static System.Console;
using ClassLib;

string username = ReadLine();

if(username == "МАША")
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
