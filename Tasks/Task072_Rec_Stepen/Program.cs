// 72. Написать программу возведения числа А в целую стень B

using static System.Console;

Clear();

WriteLine("Vvedite chislo A");
int a = int.Parse(ReadLine());
WriteLine("Vvedite stepen B");
int b = int.Parse(ReadLine());

int Stepen(int num, int step)
{
    if (step == 1) return num;
    else return num * Stepen(num, --step);
}

WriteLine(Stepen(a,b).ToString());