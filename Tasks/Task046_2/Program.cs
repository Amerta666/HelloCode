// Задача 46:** Написать программу масштабирования фигуры
// Для тех, кто ушёл далеко вперёд, — усложнение.
// Сделать так, чтобы:
// 1. Вершины фигуры задавались списком  (в одну строку). 
//                    Например: "(0,0) (2,0) (2,2) (0,2)".
// 2. Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
// 3. В результате были выводились полученные координаты.
// При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"`

using static System.Console;
using System.Linq;

Point[] points = new Point[100];

int i = 0;
int count = 1;
do
{
    WriteLine("Vvedite koordinati tochek cherez zapyatuyu");
    string[] point = ReadLine().Split(',');
    points[i] = new Point() { X = int.Parse(point[0]), Y = int.Parse(point[1]) };
    i++;
    count++;
}
while (count < 5);

//WriteLine("Vvedite kooficient masshtabirovaniya");
//int k = int.Parse(ReadLine());

//Point p1 = points;
// Point Y = сityY.First(x=>x.Temp==сityY.Max(c=>c.Y));
// WriteLine($"Самый холодный город {min.X} {min.Y}");
// WriteLine($"Самый тёплый город {max.X} {max.Y}");
WriteLine(Point[X,Y]);


struct Point
{
    public int X;
    public int Y;
}