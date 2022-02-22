// Задача 46:** Написать программу масштабирования фигуры

using static System.Console;

double[] pointOne = {0,0};
double[] pointTwo = {0,2};
double[] pointFree = {2,0};
double[] pointFour = {2,2};

WriteLine("Vvedite koefficient masshtabirovaniya");
double k = double.Parse(ReadLine());

for (int i = 0; i < pointOne.Length; i++)
{
    pointOne[i] = pointOne[i] * k;
}

for (int i = 0; i < pointTwo.Length; i++)
{
    pointTwo[i] = pointTwo[i] * k;
}

for (int i = 0; i < pointFree.Length; i++)
{
    pointFree[i] = pointFree[i] * k;
}

for (int i = 0; i < pointFour.Length; i++)
{
    pointFour[i] = pointFour[i] * k;
}

WriteLine(String.Join(" ",pointOne));
WriteLine(String.Join(" ",pointTwo));
WriteLine(String.Join(" ",pointFree));
WriteLine(String.Join(" ",pointFour));