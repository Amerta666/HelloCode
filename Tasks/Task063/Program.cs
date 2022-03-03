// Задача 63: Сформировать трехмерный массив не повторяющимися 
// двузначными числами показать его построчно на экран выводя 
// индексы соответствующего элемента

using static System.Console;

Clear();


int[,,] matrix = new int[3, 3, 3];

FillArray(matrix);
PrintArray(matrix);

void FillArray(int[,,] matrix)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                int random = new Random().Next(3 * 3 * 3 + 3);
                if (!Find(random, matrix)) ;
                {
                    matrix[i, j, k] = random;
                    k++;
                }
            }

        }
    }
}
void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                Write($"{matrix[i, j, k]} ");
            }
            WriteLine();
        }

    }
}

voif Find(matrix);
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(0); j++)
    {
        for (int k1 = 0; k1 < mas.GetLength(1); k1++)
        {
            if (mas[i, j] == mas[i, k1])
            mas[i, j] + mas[i, k1];
        }
    }
}