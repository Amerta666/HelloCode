﻿// Задача 46:** Написать программу масштабирования фигуры
// Для тех, кто ушёл далеко вперёд, — усложнение.
// Сделать так, чтобы:
// 1. Вершины фигуры задавались списком  (в одну строку). 
//                    Например: "(0,0) (2,0) (2,2) (0,2)".
// 2. Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
// 3. В результате были выводились полученные координаты.
// При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"`

using static System.Console;
using System.Linq;

WriteLine("Vvedite koefficient mashtabirovaniya figuri");
int k = int.Parse(ReadLine());

Point p1 = new Point() { X = 2, Y = 2 };
Point p2 = new Point() { X = 22, Y = 2 };
Point p3 = new Point() { X = 22, Y = 22 };
Point p4 = new Point() { X = 2, Y = 22 };

Point K = Point p1(X, Y) * k;
WriteLine();

//MyStruct min = сityTemp.First(x=>x.Temp==сityTemp.Min(c=>c.Temp));
//MyStruct max = сityTemp.First(x=>x.Temp==сityTemp.Max(c=>c.Temp));

struct Point
{
    public int X;
    public int Y;
}