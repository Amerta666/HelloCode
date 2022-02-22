// 44. Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, 
// y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы

using static System.Console;

WriteLine("Vvedite k1");
double k1 = double.Parse(ReadLine());
WriteLine("Vvedite b1");
double b1 = double.Parse(ReadLine());
WriteLine("Vvedite k2");
double k2 = double.Parse(ReadLine());
WriteLine("Vvedite b2");
double b2 = double.Parse(ReadLine());

double x = (b1 - b2) / (k2 - k1);
WriteLine($"X ravna {x}");
double y = k1 * x + b1;
WriteLine($"Y ravna {y}");
WriteLine($"Tochka peresecheniya 2 pryamih ravna ({x}, {y})");