// 64. Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника

using static System.Console;
Clear();

WriteLine("Zadaite kolichestvo strok treugolnika Paskalya");
int rowsCount = int.Parse(ReadLine());

int[,] triangleArray = new int[rowsCount, rowsCount];

for (int i = 0; i < triangleArray.GetLength(0); i++)
{
    triangleArray[i, 0] = 1;
}

for (int i = 1; i < triangleArray.GetLength(0); i++)
{
    for (int j = 1; j < triangleArray.GetLength(1); j++)
    {
        triangleArray[i, j] = triangleArray[i - 1, j - 1] + triangleArray[i - 1, j];
    }
}

Clear();
int maxNumberLenght = triangleArray[rowsCount - 1, rowsCount / 2].ToString().Length;

for (int i = 0; i < triangleArray.GetLength(0); i++)
{
    string outputString = string.Empty;
    for (int j = 0; j < triangleArray.GetLength(1); j++)
    {
        if (triangleArray[i, j] != 0)
        {
            string temp = triangleArray[i, j].ToString();
            while (temp.Length <= maxNumberLenght) temp += " ";
            outputString += temp;
        }
    }
    SetCursorPosition(BufferWidth / 2 - outputString.Length / 2, i);
    Write(outputString);
}