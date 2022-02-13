// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

using static System.Console;

var random = new Random();
bool X = random.Next(2) == 1;
bool Y = random.Next(2) == 1;
bool result = true;

if (!(X | Y) == !X & !Y) result = true;
else result = false;  

WriteLine(result);
WriteLine($"X = {X},Y = {Y}");
