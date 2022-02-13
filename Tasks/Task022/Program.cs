// 22. Найти расстояние между точками в пространстве 2D/3D

using static System.Console;

WriteLine("Расстояние между точками в пространстве 2D/3D?");
WriteLine("Введите - 2 если в 2D и 3 если в 3D");
int D = int.Parse(ReadLine());
double length = 0;

if (D == 2)
{
    WriteLine("Введите координаты первой точки X");
    int x1 = int.Parse(ReadLine());
    WriteLine("Введите координаты первой точки Y");
    int y1 = int.Parse(ReadLine());
    WriteLine("Введите координаты второй точки X");
    int x2 = int.Parse(ReadLine());
    WriteLine("Введите координаты второй точки Y");
    int y2 = int.Parse(ReadLine());
    length = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
    WriteLine("Расстояние между точками в 2D = " + Math.Sqrt(length));
}
if (D == 3)
{
    WriteLine("Введите координаты первой точки X");
    int x1 = int.Parse(ReadLine());
    WriteLine("Введите координаты первой точки Y");
    int y1 = int.Parse(ReadLine());
    WriteLine("Введите координаты первой точки Z");
    int z1 = int.Parse(ReadLine());
    WriteLine("Введите координаты второй точки X");
    int x2 = int.Parse(ReadLine());
    WriteLine("Введите координаты второй точки Y");
    int y2 = int.Parse(ReadLine());
    WriteLine("Введите координаты второй точки Z");
    int z2 = int.Parse(ReadLine());
    length = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1) ;
    WriteLine("Расстояние между точками в 3D = " + Math.Sqrt(length));
}
else WriteLine("Ошибка ввода");