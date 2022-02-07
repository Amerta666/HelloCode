// 19. Определить номер четверти плоскости, 
// в которой находится точка с координатами Х и У, 
// причем X ≠ 0 и Y ≠ 0
using static System.Console;

WriteLine("Введите первое число");
int x = Convert.ToInt32(ReadLine());

WriteLine("Введите второе число");
int y = Convert.ToInt32(ReadLine());

WriteLine(GetAnswer(x, y));


string GetAnswer(int x, int y)
{
    if (x == 0 | y == 0) return $"Ошибка ввода";
    if (x > 0 & y > 0) return $"Точки {x} и {y} находятся в первой четверти";
    if (x < 0 & y > 0) return $"Точки {x} и {y} находятся во второй четверти";
    if (x < 0 & y < 0) return $"Точки {x} и {y} находятся в третьей четверти";
    if (x > 0 & y < 0) return $"Точки {x} и {y} находятся в четвёртой четверти";
    return $"Ошибка ввода";
}
