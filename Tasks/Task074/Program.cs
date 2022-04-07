// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//     Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

using static System.Console;

Clear();

WriteLine("Vvedite n");
int n = int.Parse(ReadLine());
int k = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        WriteLine($"{k++} {new String(word)} "); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[n]);   // количество букв в слове