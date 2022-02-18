// 41. Выяснить являются ли три числа сторонами треугольника 

using static System.Console;

WriteLine("Input first number");
int A = int.Parse(ReadLine());
WriteLine("Input second number");
int B = int.Parse(ReadLine());
WriteLine("Input third number");
int C = int.Parse(ReadLine());

int max = A;
int min1 = A;
int min2 = A;

if (B > A) max = B;
if (C > B) max = C;

if (B < A) min1 = B;
if (C < B) min1 = C;

if (A < B && B < C) min2 = B;
if (B < C && C < A) min2 = C;
if (B < A && A < C) min2 = A;

WriteLine($"{max}, {min2}, {min1}");

WriteLine(GetAnswer(max, min1, min2));

string GetAnswer(int max, int min1, int min2)
{
    if (max < min1 + min2) return $"The numbers are the sides of the triangle";
    return $"The numbers are NOT the sides of the triangle";
}